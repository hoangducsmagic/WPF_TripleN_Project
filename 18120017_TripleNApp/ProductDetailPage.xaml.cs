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
    /// Interaction logic for ProductDetailPage.xaml
    /// </summary>
    public partial class ProductDetailPage : Page
    {
        Product Product;
        
        public ProductDetailPage(Product CurrentProduct)
        {
            InitializeComponent();
            Product = CurrentProduct;
            DataContext = Product;
            PicListview.ItemsSource = Product.hinhanh;
            ColorListview.ItemsSource = Product.mausac;
            SizeListview.ItemsSource = Product.kichthuoc;
            Avt.ImageSource = new BitmapImage(new Uri(Product.ImagePathConverter(Product.hinhanh.ElementAtOrDefault(0).pic), UriKind.Absolute));
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PicListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedIndex;
            Avt.ImageSource = new BitmapImage(new Uri(Product.ImagePathConverter(Product.hinhanh.ElementAtOrDefault(selection).pic), UriKind.Absolute));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProductListPage());
        }
    }
}
