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
    /// Interaction logic for SourceListPage.xaml
    /// </summary>
    public partial class SourceListPage : Page
    {
        ImportBUS ImportBUS = new ImportBUS();
        ImportDAO ImportDAO = new ImportDAO();
        List<Import> SourceList = new List<Import>();
        List<Import> SearchList = new List<Import>();

        public SourceListPage()
        {
            InitializeComponent();
            SourceList = ImportDAO.GetSourceList();
            SearchList = ImportDAO.GetSourceList();
            SourceListview.ItemsSource = SourceList;
        }

        private void SourceListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedItem as Import;
            this.NavigationService.Navigate(new SourceDetailPage(selection));
        }

        private void SourceDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selection = (sender as Button).DataContext as Import;
            var productlist=ImportBUS.SourceDelete(selection);
            if (productlist != null)
            {
                MessageBox.Show($"Bạn không thể xóa nguồn hàng này vì còn {productlist.Item1} sản phẩm đang bán bao gồm: {productlist.Item2}");
            }
            else
            {
                SourceList.Remove(selection);
                SourceListview.Items.Refresh();
                MessageBox.Show("Đã xóa nguồn nhập hàng.");
            }            
        }

        private void SearchTexttBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                SearchButton_Click(sender, e);
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

            foreach (var item in SourceList)
            {
                string tmp = RemoveUnicode(item.ten.ToLower());

                if (tmp.Contains(searchText))
                    SearchList.Add(item);
            }

            if (SearchList.Count() == 0)
            {
                NotExistTextblock.Visibility = Visibility.Visible;
                ContentPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                NotExistTextblock.Visibility = Visibility.Collapsed;
                ContentPanel.Visibility = Visibility.Visible;
                SourceListview.ItemsSource = SearchList;
            }
        }

        private void SourceAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SourceAddPage());
        }
    }
}
