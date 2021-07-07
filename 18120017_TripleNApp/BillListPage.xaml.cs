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
        public BillListPage()
        {
            InitializeComponent();
            BillListview.ItemsSource = BillDAO.GetBillData();
        }

        private void BillAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BillAddPage());
        }

        private void BillListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void BillDeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTexttBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
