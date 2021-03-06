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
    /// Interaction logic for SourceAddPage.xaml
    /// </summary>
    public partial class SourceAddPage : Page
    {
        ImportBUS ImportBUS = new ImportBUS();
        Import Source = new Import();
        IDGeneration IDGeneration = new IDGeneration();

        public SourceAddPage()
        {
            InitializeComponent();
        }

        private void IDGenerateButton_Click(object sender, RoutedEventArgs e)
        {
            SourceIDTextbox.Text = IDGeneration.RandomID();
        }

        bool InputCheck()
        {
            if (SourceIDTextbox.Text == "") { MessageBox.Show("Vui lòng nhập  mã nguồn!");return false; }
            if (SourceNameTextbox.Text == "") { MessageBox.Show("Vui lòng nhập tên nguồn!");return false; }
            if (SourceAddressTextbox.Text == "") { MessageBox.Show("Vui lòng nhập địa chỉ nguồn!");return false; }
            if (SourceLinkTextbox.Text == "") { MessageBox.Show("Vui lòng nhập link nguồn!");return false; }
            return true;
        }
        private void SourceAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputCheck()){
                Source.ten = SourceNameTextbox.Text;
                Source.diachi = SourceAddressTextbox.Text;
                Source.link = SourceLinkTextbox.Text;
                Source.ma = SourceIDTextbox.Text;

                var addres=ImportBUS.SourceAdd(Source);

                if (addres != "")
                {
                    MessageBox.Show(addres);
                    return;
                }

                MessageBox.Show("Đã thêm nguồn hàng mới.");
                this.NavigationService.Navigate(new SourceListPage());
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SourceListPage());
        }
    }
}
