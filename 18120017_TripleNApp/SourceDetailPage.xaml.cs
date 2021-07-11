using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Import Source = new Import();
        ImportBUS ImportBUS = new ImportBUS();

        public SourceDetailPage(Import selecteditem)
        {
            InitializeComponent();
            Source = selecteditem;

            DataContext = Source;

            if (Source.cothongbao)
            {
                AnounPanel.Visibility = Visibility.Visible;
                AnounAddButton.Visibility = Visibility.Collapsed;
            } else
            {
                AnounPanel.Visibility = Visibility.Collapsed;
                AnounDeleteButton.Visibility = Visibility.Collapsed;
            }
        }

        private void LinkTextblock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start(LinkTextblock.Text);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SourceListPage());
        }

        private void AnounAddButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new AnounAddDialog();
            screen.ShowDialog();
            var value = AnounAddDialog.value;
            var date = AnounAddDialog.date;
            if (value == "") return;

            Source.cothongbao = true;
            Source.thoigian = date;
            Source.noidung = value;
            ImportBUS.SourceUpdate(Source);
            Refresh();
            AnounPanel.Visibility = Visibility.Visible;
            AnounAddButton.Visibility = Visibility.Collapsed;
            AnounDeleteButton.Visibility = Visibility.Visible;
        }

        private void AnounDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Source.cothongbao = false;
            ImportBUS.SourceUpdate(Source);
            AnounPanel.Visibility = Visibility.Collapsed;
            AnounDeleteButton.Visibility = Visibility.Collapsed;
            AnounAddButton.Visibility = Visibility.Visible;
        }

        private void SouceUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new SourceUpdateDialog(Source);
            screen.ShowDialog();
            var ischange = SourceUpdateDialog.ischange;
            if (ischange)
            {
                MessageBox.Show("bị khùng");
                var value = SourceUpdateDialog.value;
                ImportBUS.SourceUpdate(value);
                Source = value;
                Refresh();
            } 
        }

        private void StatisticDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có đồng ý reset lại dữ liệu thống kê?","RESET DỮ LIỆU", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Source.tongsanpham = 0;
                Source.tongtien = 0;
                ImportBUS.SourceUpdate(Source);
                Refresh();

            }
            else
                return;
        }

        void Refresh()
        {
            DataContext = null;
            DataContext = Source;
        }
    }
}

