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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pagination.CurrentPage = 1;
            MainFrame.NavigationService.Navigate(new ProductListPage());

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            MainFrame.IsEnabled = false;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            MainFrame.IsEnabled = true;
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (60 * index), 0, 0);
        }

        private void ProductButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            MainFrame.IsEnabled = true;
            MoveCursorMenu(0);

            
            Pagination.CurrentPage = 1;
            MainFrame.NavigationService.Navigate(new ProductListPage());
        }

        private void BillButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            MainFrame.IsEnabled = true;
            MoveCursorMenu(1);
            MainFrame.NavigationService.Navigate(new BillListPage());
        }

        private void ImportButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            MainFrame.IsEnabled = true;
            MoveCursorMenu(2);
            MainFrame.NavigationService.Navigate(new SourceListPage());
        }

        private void StatisticButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            MainFrame.IsEnabled = true;
            MoveCursorMenu(3);
            MainFrame.NavigationService.Navigate(new StatisticPage());
        }

        private void SettingButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            MainFrame.IsEnabled = true;
            MoveCursorMenu(4);
            MainFrame.NavigationService.Navigate(new SettingPage());
        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new InfoPage());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ImportBUS ImportBUS = new ImportBUS();
            ImportBUS.MakeAnouncement();
        }
    }
}
