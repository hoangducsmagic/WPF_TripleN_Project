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
    /// Interaction logic for ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        ProductDAO ProductDAO = new ProductDAO();
        public ProductListPage()
        {
            InitializeComponent();
            ProductListview.ItemsSource = ProductDAO.GetProductData();
            TypeTreeview.ItemsSource = ProductDAO.GetTypeData();

            
        }

        private void TypeListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTexttBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

      

        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentPageTextBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentPageTextBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentPageTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void CurrentPageTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedItem as Product;
            if (selection == null) return;
            this.NavigationService.Navigate(new ProductDetailPage(selection));
        }

        private void ProductUpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductDeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProductAddPage());
        }
    }
}
