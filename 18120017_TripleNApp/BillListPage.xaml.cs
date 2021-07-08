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
        public BillListPage()
        {
            InitializeComponent();
            BillList= BillDAO.GetBillData();
            BillListview.ItemsSource = BillList;
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
            BillListview.Items.Refresh();
            MessageBox.Show("Đã xóa hóa đơn");
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTexttBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
