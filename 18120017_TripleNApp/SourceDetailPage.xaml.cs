using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for SourceDetailPage.xaml
    /// </summary>
    public partial class SourceDetailPage : Page
    {
        public SourceDetailPage(Import Source)
        {
            InitializeComponent();
            DataContext = Source;
        }

        private void LinkTextblock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start(LinkTextblock.Text);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SourceListPage());
        }
    }
}

