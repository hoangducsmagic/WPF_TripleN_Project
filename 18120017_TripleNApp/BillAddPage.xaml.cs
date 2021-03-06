using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _18120017_TripleNApp
{
    /// <summary>
    /// Interaction logic for BillAddPage.xaml
    /// </summary>
    public partial class BillAddPage : Page
    {
        Bill Bill = new Bill();
        
        ProductDAO ProductDAO = new ProductDAO();
        List<ProductInBill> BuyList = new List<ProductInBill>();
        List<Product> ProductList = new List<Product>();
        List<Discount> DiscountList = new List<Discount>();
        BillBUS BillBUS = new BillBUS();
        CustomerDAO CustomerDAO = new CustomerDAO();
        

        public BillAddPage()
        {
            InitializeComponent();
            TotalMoneyTextbox.DataContext = Bill.thanhtien;
            ProductList = ProductDAO.GetProductData();
            ProductNameCombobox.ItemsSource = ProductList;
            ProductListview.ItemsSource = BuyList;
            DiscountListview.ItemsSource = DiscountList;
            Bill.khachhang = new Customer();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BillListPage());
        }

        bool InputCheck()
        {
            if (BillIDTextbox.Text == "") { MessageBox.Show("Vui lòng nhập mã đơn hàng!");return false; }
            if (DateCreatingPicker.SelectedDate==null) { MessageBox.Show("Vui lòng chọn ngày lập đơn!");return false; }
            try { DateTime.Parse(DateCreatingPicker.Text); } catch (Exception) { MessageBox.Show("Ngày lập đơn không hợp lệ!");return false; }
            if (MemNameTextbox.Text == "") { MessageBox.Show("Vui lòng nhập tên khách hàng!");return false; }
            if (MemPhoneTextbox.Text == "") { MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!");return false; }
            if (MemAddressTextbox.Text == "") { MessageBox.Show("Vui lòng nhập địa chỉ nhận  hàng!");return false; }
            if (BuyList.Count() == 0) { MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào đơn!");return false; }
            if (TransportTextbox.Text=="") { MessageBox.Show("Vui lòng thêm phí vận chuyển!");return false; }

            return true;
        }

        private void BillAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!InputCheck()) return;

            Bill.khachhang.ten = MemNameTextbox.Text;
            Bill.khachhang.sdt = MemPhoneTextbox.Text;
            Bill.khachhang.diachi = MemAddressTextbox.Text;
            Bill.ma = BillIDTextbox.Text;
            Bill.ngaylap = (DateTime)DateCreatingPicker.SelectedDate;
            Bill.ProductList = BuyList;
            Bill.vanchuyen = Int32.Parse(TransportTextbox.Text);


            Bill.DiscountList = BillBUS.GetDiscountList(BuyList, Bill.khachhang, (DateTime)DateCreatingPicker.SelectedDate, Bill.vanchuyen);

            var addres=BillBUS.BillAdd(Bill);
            if (addres != "")
            {
                MessageBox.Show(addres);
                return;
            }
            MessageBox.Show("Đã thêm đơn hàng.");
            this.NavigationService.Navigate(new BillListPage());
        }

        private void GetDiscountInfo()
        {
            DiscountList = BillBUS.GetDiscountList(BuyList, Bill.khachhang, (DateTime)DateCreatingPicker.SelectedDate, Bill.vanchuyen);
            if (DiscountList.Count() > 0)
            {
                NoDiscountTextblock.Visibility = Visibility.Collapsed;
                DiscountListview.Visibility = Visibility.Visible;
                DiscountListview.ItemsSource = DiscountList;
                TotalMoneyTextbox.DataContext = (Bill.thanhtien - DiscountList.Sum(c => c.sotien)+Bill.vanchuyen).ToString();
            }
            else
            {
                NoDiscountTextblock.Visibility = Visibility.Visible;
                DiscountListview.Visibility = Visibility.Collapsed;
            }
        }

        private void ProductAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductNameCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm!");
                return;
            }

            if (Int32.Parse(ProductAmountTextbox.Text) <= 0)
            {
                MessageBox.Show("Số lượng sản phẩm không hợp lệ!");
                return;
            }

            if (BuyList.Find(c=>c.masanpham==ProductIDTextblock.Text)!=null)
            {
                MessageBox.Show("Sản phẩm bị trùng!");
                return;
            }

            var selectedproduct = ProductList.ElementAtOrDefault(ProductNameCombobox.SelectedIndex);
            ProductInBill newproduct=new ProductInBill()
            {
                tensanpham = selectedproduct.ten,
                dongia = selectedproduct.giaban,
                masanpham = selectedproduct.ma,
                soluong = Int32.Parse(ProductAmountTextbox.Text)
            };
            newproduct.thanhtien = newproduct.dongia * newproduct.soluong;

      

            BuyList.Add(newproduct);
            ProductListview.Items.Refresh();
            Bill.thanhtien += newproduct.thanhtien;
            TotalMoneyTextbox.DataContext = Bill.thanhtien;

            GetDiscountInfo();

            ProductNameCombobox.SelectedIndex=-1;
            ProductAmountTextbox.Text = "1";
            ProductIDTextblock.Text = "";
            ProductSumTextblock.Text = "";
            ProductPriceTextblock.Text = "";
            
        }

        private void ProductAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ProductAmountTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ProductAmountTextbox.Text == "")
            {
                ProductAmountTextbox.Text = "1";
            }
            if (ProductNameCombobox.SelectedIndex == -1) return;

            var selectedproduct = ProductList.ElementAtOrDefault(ProductNameCombobox.SelectedIndex);
            ProductSumTextblock.Text = (Int32.Parse(ProductAmountTextbox.Text) * selectedproduct.giaban).ToString();
        }

        private void ProductNameCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedproduct = ProductList.ElementAtOrDefault(ProductNameCombobox.SelectedIndex);
            if (selectedproduct == null) return;
            ProductIDTextblock.Text = selectedproduct.ma;
            ProductPriceTextblock.Text = selectedproduct.giaban.ToString();
            ProductSumTextblock.Text = (Int32.Parse(ProductAmountTextbox.Text) * selectedproduct.giaban).ToString();

        }

        private void ProductDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selection = (sender as Button).DataContext as ProductInBill;
            Bill.thanhtien -= selection.thanhtien;
            TotalMoneyTextbox.DataContext= Bill.thanhtien.ToString();
            BuyList.Remove(selection);
            ProductListview.Items.Refresh();
            GetDiscountInfo();
        }

        private void GenerateIDButton_Click(object sender, RoutedEventArgs e)
        {
            BillIDTextbox.Text = BillBUS.RandomID();
        }

        private void MemChooseButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new MemChooseDialog();
            screen.ShowDialog();
            var value = MemChooseDialog.value;
            if (value == "Not selected yet") return;

            Bill.khachhang.ma = value;
            var query = CustomerDAO.FindCustomer(value);
            Bill.khachhang = query;
            MemNameTextbox.Text = query.ten;
            MemAddressTextbox.Text = query.diachi;
            MemPhoneTextbox.Text = query.sdt;

            var oldmem = CustomerDAO.FindCustomer(MemNameTextbox.Text, MemPhoneTextbox.Text);
            if (oldmem != null)
            {
                
                Bill.khachhang = oldmem;
                Bill.DiscountList = BillBUS.GetDiscountList(BuyList, Bill.khachhang, (DateTime)DateCreatingPicker.SelectedDate, Bill.vanchuyen);
                DiscountListview.ItemsSource = DiscountList;
            }
        }

        private void DateCreatingPicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BuyList.Count()==0) return;
            GetDiscountInfo();
        }

        private void TransportTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TransportTextbox.Text == "") Bill.vanchuyen = 0;
            else Bill.vanchuyen = Double.Parse(TransportTextbox.Text);
            TotalMoneyTextbox.DataContext = (Bill.thanhtien + Bill.vanchuyen).ToString();
            GetDiscountInfo();
        }

        private void MemNameTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldmem = CustomerDAO.FindCustomer(MemNameTextbox.Text, MemPhoneTextbox.Text);
            if (oldmem != null)
            {
                Bill.khachhang = oldmem;
                DiscountList = BillBUS.GetDiscountList(BuyList, Bill.khachhang, (DateTime)DateCreatingPicker.SelectedDate, Bill.vanchuyen);
                DiscountListview.ItemsSource = DiscountList;

            }
        }

        private void MemPhoneTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldmem = CustomerDAO.FindCustomer(MemNameTextbox.Text, MemPhoneTextbox.Text);
            if (oldmem != null)
            {
                Bill.khachhang = oldmem;
                DiscountList = BillBUS.GetDiscountList(BuyList, Bill.khachhang, (DateTime)DateCreatingPicker.SelectedDate, Bill.vanchuyen);
                DiscountListview.ItemsSource = DiscountList;

            }
        }

        private void TransportTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
