using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public BillAddPage()
        {
            InitializeComponent();
            TotalMoneyTextbox.DataContext = Bill.thanhtien;
            ProductList = ProductDAO.GetProductData();
            ProductNameCombobox.ItemsSource = ProductList;
            ProductListview.ItemsSource = BuyList;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BillListPage());
        }

        private void BillAddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductAddButton_Click(object sender, RoutedEventArgs e)
        {
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
        }

        private void ProductAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void ProductAmountTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ProductNameCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedproduct = ProductList.ElementAtOrDefault(ProductNameCombobox.SelectedIndex);
            ProductIDTextblock.Text = selectedproduct.ma;
            ProductPriceTextblock.Text = selectedproduct.giaban.ToString();
        }

        private void ProductDeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateIDButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MemChooseButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
