using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ProductUpdatePage.xaml
    /// </summary>
    public partial class ProductUpdatePage : Page
    {
        List<Pic> PicList = new List<Pic>();
        List<Color> ColorList = new List<Color>();
        List<Size> SizeList = new List<Size>();
        List<ProductType> TypeList = new List<ProductType>();
        List<ProductSource> SourceList = new List<ProductSource>();

        ProductBUS ProductBUS = new ProductBUS();
        ProductDAO ProductDAO = new ProductDAO();
        Product product;

        int beforeupdate;   // số lượng tồn kho trước khi cập nhật

        public ProductUpdatePage(Product item)
        {
            InitializeComponent();
            product = item;
            beforeupdate = product.tonkho;

            TypeList = ProductDAO.GetTypeData2();
            SourceList = ProductDAO.GetSourceData();
            TypeCombobox.ItemsSource = TypeList;
            SourceCombobox.ItemsSource = SourceList;

            DataLoad();
            
            PicListview.ItemsSource = PicList;
            SizeListview.ItemsSource = SizeList;
            ColorListview.ItemsSource = ColorList;
           

          

        }

        private void DataLoad() // load dữ  liệu lên  màn hình
        {
            

            ProductNameTextbox.Text = product.ten;
            ProductIDTextbox.Text = product.ma;
            ProductDescriptionTextbox.Text = product.mota;
            TypeCombobox.SelectedItem = TypeList.Find(c => c.ma == product.maloai);
            ImportPriceTextbox.Text = product.gianhap.ToString();
            SellPriceTextbox.Text = product.giaban.ToString();
            PercentTextbox.Text = product.phantram.ToString();
            WeightTextbox.Text = product.trongluong.ToString();
            AmountTextbox.Text = product.tonkho.ToString();
            MinimumTextbox.Text = product.toithieu.ToString();
            SourceCombobox.SelectedItem = SourceList.Find(c => c.ma == product.manguon);

            PicList = product.hinhanh;
            ColorList = product.mausac;
            SizeList = product.kichthuoc;
        }

        private void PicAddButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OpenFileDialog();
            screen.Multiselect = true;
            if (screen.ShowDialog() == true)
            {
                var files = screen.FileNames;
                foreach (var file in files)
                {
                    var info = new FileInfo(file);
                    PicList.Add(new Pic() { path = info.FullName });
                    PicListview.Items.Refresh();
                }
            }
        }

        private void PicDelButton_Click(object sender, RoutedEventArgs e)
        {
            var items = PicListview.SelectedItems;
            foreach (var item in items)
            {
                PicList.RemoveAt(PicListview.Items.IndexOf(item));
            }

            PicListview.Items.Refresh();
        }

        private void ColorAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ColorPicker.SelectedColorText == "") return;
            foreach (var item in ColorList)
                if (item.color == ColorPicker.SelectedColorText)
                {
                    MessageBox.Show("Màu sắc bị trùng!");
                    return;
                }

            ColorList.Add(new Color() { color = ColorPicker.SelectedColorText });
            ColorListview.Items.Refresh();
        }

        private void ColorDelButton_Click(object sender, RoutedEventArgs e)
        {
            var items = ColorListview.SelectedItems;
            foreach (var item in items)
            {
                ColorList.RemoveAt(ColorListview.Items.IndexOf(item));
            }

            ColorListview.Items.Refresh();
        }

        private void SizeAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (SizeTextbox.Text == "") return;
            foreach (var item in SizeList)
                if (item.size == SizeTextbox.Text)
                {
                    MessageBox.Show("Kích thước bị trùng!");
                    return;
                }
            SizeList.Add(new Size() { size = SizeTextbox.Text });
            SizeListview.Items.Refresh();
            SizeTextbox.Clear();
        }

        private void SizeDelButton_Click(object sender, RoutedEventArgs e)
        {
            var items = SizeListview.SelectedItems;
            foreach (var item in items)
            {
                SizeList.RemoveAt(SizeListview.Items.IndexOf(item));
            }

            SizeListview.Items.Refresh();
        }

        private void TypeAddButton_Click(object sender, RoutedEventArgs e)
        {
            TypeAddDialog dialog = new TypeAddDialog();
            dialog.ShowDialog();
            var value = TypeAddDialog.value;
            if (value == "") return;

            ProductType newtype = new ProductType() { ma = ProductBUS.RandomID(), ten = value };
            var res = TypeList.FindAll(c => c.ten == value).FirstOrDefault();
            if (res == null)
            {
                TypeList.Add(newtype);
                TypeCombobox.Items.Refresh();
            }
            else
            {
                newtype = res;
                MessageBox.Show("Loại sản phẩm đã tồn tại.");
            }
            TypeCombobox.SelectedItem = newtype;
        }

        private bool InputCheck()
        {
            if (PicList.Count() == 0) { MessageBox.Show("Vui lòng thêm hình ảnh sản phẩm!"); return false; }
            if (ProductNameTextbox.Text == "") { MessageBox.Show("Vui lòng nhập tên sản phẩm!"); return false; }
            if (ProductDescriptionTextbox.Text == "") { MessageBox.Show("Vui lòng nhập mô tả sản phẩm!"); return false; }
            if (TypeCombobox.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn loại sản phẩm!"); return false; }
            if (SizeList.Count() == 0) { MessageBox.Show("Vui lòng thêm kích thước sản phẩm!"); return false; }
            if (ColorList.Count() == 0) { MessageBox.Show("Vui lòng thêm màu sắc sản phẩm!"); return false; }
            if (SellPriceTextbox.Text == "") { MessageBox.Show("Vui lòng nhập giá bán sản phẩm!"); return false; }
            try { double.Parse(SellPriceTextbox.Text); } catch (Exception) { MessageBox.Show("Giá bán sản phẩm không hợp lệ."); return false; }
            if (ImportPriceTextbox.Text == "") { MessageBox.Show("Vui lòng thêm giá nhập sản phẩm!"); return false; }
            try { double.Parse(ImportPriceTextbox.Text); } catch (Exception) { MessageBox.Show("Giá nhập sản phẩm không hợp lệ."); return false; }
            if (PercentTextbox.Text == "") { MessageBox.Show("Vui lòng thêm phần trăm chi!"); return false; }
            try { double.Parse(PercentTextbox.Text); } catch (Exception) { MessageBox.Show("Phần trăm chi không hợp lệ."); return false; }
            if (WeightTextbox.Text == "") { MessageBox.Show("Vui lòng thêm trọng lượng sản phẩm!"); return false; }
            try { Int32.Parse(WeightTextbox.Text); } catch (Exception) { MessageBox.Show("Trọng lượng sản phẩm không hợp lệ."); return false; }
            if (AmountTextbox.Text == "") { MessageBox.Show("Vui lòng thêm số lượng sản phẩm!"); return false; }
            try { Int32.Parse(AmountTextbox.Text); } catch (Exception) { MessageBox.Show("Số lượng sản phẩm không hợp lệ."); return false; }
            if (MinimumTextbox.Text == "") { MessageBox.Show("Vui lòng nhập số lượng tối thiểu!"); return false; }
            try { double.Parse(MinimumTextbox.Text); } catch (Exception) { MessageBox.Show("Số lượng tối thiểu không hợp lệ."); return false; }
            if (SourceCombobox.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn nguồn nhập hàng!"); return false; }
            return true;
        }

        private void ProductUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!InputCheck()) return;

            product.ten = ProductNameTextbox.Text;
            product.ma = ProductIDTextbox.Text;
            product.mota = ProductDescriptionTextbox.Text;
            product.maloai = TypeList.ElementAtOrDefault(TypeCombobox.SelectedIndex).ma;
            product.tenloai = TypeList.ElementAtOrDefault(TypeCombobox.SelectedIndex).ten;
            product.mota = ProductDescriptionTextbox.Text;
            product.trongluong = Double.Parse(WeightTextbox.Text);
            product.daban = 0;
            product.tonkho = Int32.Parse(AmountTextbox.Text);
            product.gianhap = Double.Parse(ImportPriceTextbox.Text);
            product.giaban = Double.Parse(SellPriceTextbox.Text);
            product.phantram = Double.Parse(PercentTextbox.Text);
            product.manguon = SourceList.ElementAtOrDefault(SourceCombobox.SelectedIndex).ma;
            product.toithieu = Int32.Parse(MinimumTextbox.Text);

            product.mausac = ColorList;
            product.kichthuoc = SizeList;

            product.hinhanh = PicList;

            string updateresult = ProductBUS.ProductUpdate(product);
            if (updateresult == "OK")
            {
                if (product.tonkho > beforeupdate)
                {
                    var result = MessageBox.Show("Bạn có muốn cập nhật dữ liệu thống kê nguồn nhập không?", "Cập nhật dữ liệu", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        ImportBUS ImportBUS = new ImportBUS();
                        ImportBUS.AddSourceStatic(product.manguon, product.tonkho - beforeupdate, (product.tonkho - beforeupdate) * product.gianhap);
                    }
                }
                MessageBox.Show("Cập nhật sản phẩm thành công.");
                this.NavigationService.Navigate(new ProductDetailPage(product));
            }
            else
                MessageBox.Show(updateresult);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProductListPage());
        }
    }
}
