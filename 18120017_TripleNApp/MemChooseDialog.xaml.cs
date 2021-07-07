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
using System.Windows.Shapes;

namespace _18120017_TripleNApp
{
    /// <summary>
    /// Interaction logic for MemChooseDialog.xaml
    /// </summary>
    public partial class MemChooseDialog : Window
    {
        List<Customer> MemList = new List<Customer>();
        public static string value = "Not selected yet";
        CustomerDAO CustomerDAO = new CustomerDAO();
        

        public MemChooseDialog()
        {
            InitializeComponent();
            MemList = CustomerDAO.GetCustomerData();
            if (MemList.Count() == 0)
            {
                EmptyTextblock.Visibility = Visibility.Visible;
                OKButton.IsEnabled = false;
            }
            else
            {
                MemListview.ItemsSource = MemList;
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (MemListview.SelectedIndex > -1)
            {
                value = MemList[MemListview.SelectedIndex].ma;
            }
            else
            {
                value = "Not selected yet";
            }
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            value = "Not selected yet";
            this.Close();
        }
    }
}
