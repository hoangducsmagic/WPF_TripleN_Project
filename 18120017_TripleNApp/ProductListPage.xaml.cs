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
    /// Interaction logic for ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        ProductDAO ProductDAO = new ProductDAO();
        ProductBUS ProductBUS = new ProductBUS();
        Pagination Pagination = new Pagination();

        List<Product> ProductList = new List<Product>();
        List<Product> SearchList = new List<Product>();
        List<ProductType> ProductByType = new List<ProductType>();

        public ProductListPage()
        {
            InitializeComponent();

            ProductList= ProductDAO.GetProductData();
            SearchList = ProductDAO.GetProductData();
            Pagination.update(ProductList.Count());
            PageNavigationRefresh();
            ProductListview.ItemsSource = ProductList.Skip(Pagination.skip()).Take(Pagination.take());
         

            ProductByType = ProductDAO.GetTypeData();
            TypeTreeview.ItemsSource = ProductByType;

        }

        void PageNavigationRefresh()
        {
            CurrentPageTextBox.Text = Pagination.CurrentPage.ToString();
            PreviousPageButton.IsEnabled = Pagination.CurrentPage != 1;
            NextPageButton.IsEnabled = Pagination.CurrentPage != Pagination.TotalPage;
        }

        private void TypeListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedItem as Product;
            var tam = ProductDAO.FindProduct(selection.ma);
            this.NavigationService.Navigate(new ProductDetailPage(tam));
        }

        string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í", "ì", "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự", "ý", "ỳ", "ỷ", "ỹ", "ỵ", };
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y", };

            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }

            return text;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text;
            searchText = RemoveUnicode(searchText.ToLower());
            SearchList.Clear();

            foreach (var item in ProductList)
            {
                string tmp = RemoveUnicode(item.ten.ToLower());

                if (tmp.Contains(searchText))
                    SearchList.Add(item);
            }

            if (SearchList.Count() == 0)
            {
                NotExistTextblock.Visibility = Visibility.Visible;
                PageNavigationPanel.Visibility = Visibility.Hidden;
                ProductListview.ItemsSource = null;
            }
            else
            {
                NotExistTextblock.Visibility = Visibility.Collapsed;
                PageNavigationPanel.Visibility = Visibility.Visible;
                Pagination.CurrentPage = 1;
                Pagination.update(SearchList.Count());
                PageNavigationRefresh();
                ProductListview.ItemsSource = SearchList.Skip(Pagination.skip()).Take(Pagination.take());
            }
        }

        private void SearchTexttBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                SearchButton_Click(sender, e);
        }

      

        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            Pagination.CurrentPage--;
            PageNavigationRefresh();
            ProductListview.ItemsSource = SearchList.Skip(Pagination.skip()).Take(Pagination.take());
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            Pagination.CurrentPage++;
            PageNavigationRefresh();
            ProductListview.ItemsSource = SearchList.Skip(Pagination.skip()).Take(Pagination.take());
        }

        private void CurrentPageTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            CurrentPageTextBox.Text = $"{Pagination.CurrentPage} of {Pagination.TotalPage}";

        }

        private void CurrentPageTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            CurrentPageTextBox.Text = Pagination.CurrentPage.ToString();
            CurrentPageTextBox.SelectAll();
        }

        private void CurrentPageTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CurrentPageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                int page = Int32.Parse(CurrentPageTextBox.Text);

                if (page < 1 || page > Pagination.TotalPage)
                {
                    CurrentPageTextBox.Text = $"{Pagination.CurrentPage} of {Pagination.TotalPage}";
                    return;
                }

                Pagination.CurrentPage = page;
                PageNavigationRefresh();
                ProductListview.ItemsSource = ProductList.Skip(Pagination.skip()).Take(Pagination.take());
            }
        }

        

        private void ProductListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedItem as Product;
            if (selection == null) return;
            this.NavigationService.Navigate(new ProductDetailPage(selection));
        }

        private void ProductUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var selection = (sender as Button).DataContext as Product;
            this.NavigationService.Navigate(new ProductUpdatePage(selection));
        }

        private void ProductDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selection = (sender as Button).DataContext as Product;
            ProductBUS.ProductDelete(selection);
            
            ProductListview.ItemsSource = ProductDAO.GetProductData();
            TypeTreeview.ItemsSource = ProductDAO.GetTypeData();
            MessageBox.Show("Đã xóa sản phẩm.");
        }

        private void ProductAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProductAddPage());
        }
    }
}
