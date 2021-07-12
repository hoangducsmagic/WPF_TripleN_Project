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
    /// Interaction logic for BillListPage.xaml
    /// </summary>
    public partial class BillListPage : Page
    {
        BillDAO BillDAO = new BillDAO();
        BillBUS BillBUS = new BillBUS();
        List<Bill> BillList = new List<Bill>();
        List<Bill> SearchList = new List<Bill>();
        Sorting Sorting = new Sorting();
        public BillListPage()
        {
            InitializeComponent();
            BillList= BillDAO.GetBillData();

            if (BillList.Count() == 0)
            {
                NothingToShowTextblock.Visibility = Visibility.Visible;
                ContentPanel.Visibility = Visibility.Collapsed;
                SearchZone.Visibility = Visibility.Hidden;
                return;
            }

            SearchList = Sorting.BillSort(BillList);
            BillListview.ItemsSource = SearchList;
        }

        private void BillAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BillAddPage());
        }

        private void BillListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedItem as Bill;
            if (selection == null) return;

            this.NavigationService.Navigate(new BillDetailPage(selection));
        }

        private void BillDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selection = (sender as Button).DataContext as Bill;
            BillBUS.BillDelete(selection);
            BillList.Remove(selection);
            SearchList.Remove(selection);
            BillListview.Items.Refresh();
            MessageBox.Show("Đã xóa hóa đơn");
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

            foreach (var item in BillList)
            {
                string tmp = RemoveUnicode(item.khachhang.ten.ToLower());

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
                BillListview.ItemsSource = SearchList;
                BillListview.Items.Refresh();
            }
        }

        private void SearchTexttBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                SearchButton_Click(sender, e);
        }
    }
}
