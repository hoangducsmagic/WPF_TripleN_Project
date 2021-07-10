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

        public SourceListPage()
        {
            InitializeComponent();
        }

        private void SourceListview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedItem as Import;
            this.NavigationService.Navigate(new SourceDetailPage(selection));
        }

        private void SourceDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selection = (sender as Button).DataContext as Import;
            ImportBUS.SourceDelete(selection);
            
        }

        private void SearchTexttBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SourceAddButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
