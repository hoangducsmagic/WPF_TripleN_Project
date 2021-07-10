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

        public SourceListPage()
        {
            InitializeComponent();
            SourceList = ImportDAO.GetSourceList();
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

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SourceAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SourceAddPage());
        }
    }
}
