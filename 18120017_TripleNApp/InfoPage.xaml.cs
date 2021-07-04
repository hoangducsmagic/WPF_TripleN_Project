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
    /// Interaction logic for InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void FacebookButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("http://facebook.com/hoangducsmagic");
        }

        private void GithubButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/hoangducsmagic/WPF_TripleN_Project");
        }

        private void InstagramButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("http://instagram.com/hoangducsmagic");
        }
    }
}
