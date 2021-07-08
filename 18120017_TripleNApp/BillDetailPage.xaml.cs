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
    /// Interaction logic for BillDetailPage.xaml
    /// </summary>
    public partial class BillDetailPage : Page
    {
        BillDAO BillDAO = new BillDAO();
        public BillDetailPage(Bill Bill)
        {
            InitializeComponent();
            Bill = BillDAO.GetBillData(Bill.ma);
            this.DataContext = Bill;
            ProductListview.ItemsSource = Bill.ProductList;
            DiscountListview.ItemsSource = Bill.DiscountList;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BillListPage());
        }
    }
}
