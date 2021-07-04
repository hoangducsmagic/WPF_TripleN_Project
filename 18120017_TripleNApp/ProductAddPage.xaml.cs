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
    /// Interaction logic for ProductAddPage.xaml
    /// </summary>
    public partial class ProductAddPage : Page
    {
        List<Pic> PicList = new List<Pic>();
        List<Color> ColorList = new List<Color>();
        List<Size> SizeList = new List<Size>();
        List<ProductType> TypeList = new List<ProductType>();
        List<ProductSource> SourceList = new List<ProductSource>();

        ProductDAO ProductDAO = new ProductDAO();
        IDGeneration IDGeneration = new IDGeneration();
        public ProductAddPage()
        {
            InitializeComponent();

            ProductIDTextbox.Text = IDGeneration.RandomID();

            TypeList = ProductDAO.GetTypeData2();
            SourceList = ProductDAO.GetSourceData();

            PicListview.ItemsSource = PicList;
            SizeListview.ItemsSource = SizeList;
            ColorListview.ItemsSource = ColorList;
            TypeCombobox.ItemsSource = TypeList;
            SourceCombobox.ItemsSource = SourceList;

        }

        private bool DataCheck()
        {

            return true;
        }

        private void ProductAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!DataCheck()) return;
            Product product = new Product();


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

            ProductDAO.ProductAdd(product);
            MessageBox.Show("Đã thêm sản phẩm mới.");
            this.NavigationService.Navigate(new ProductListPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

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

        private void SizeAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (SizeTextbox.Text == "") return;
            foreach (var item in SizeList)
                if (item.size == SizeTextbox.Text) return;
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

        private void ColorDelButton_Click(object sender, RoutedEventArgs e)
        {
            var items = ColorListview.SelectedItems;
            foreach (var item in items)
            {
                ColorList.RemoveAt(ColorListview.Items.IndexOf(item));
            }

            ColorListview.Items.Refresh();
        }

        private void ColorAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ColorPicker.SelectedColorText == "") return;
            foreach (var item in ColorList)
                if (item.color == ColorPicker.SelectedColorText) return;

            ColorList.Add(new Color() { color = ColorPicker.SelectedColorText });
            ColorListview.Items.Refresh();
        }

        private void CategoryAddButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
