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
    /// Interaction logic for SourceUpdateDialog.xaml
    /// </summary>
    public partial class SourceUpdateDialog : Window
    {
        
        public static bool ischange;
        public static Import value=new Import();

        public SourceUpdateDialog(Import item)
        {
            InitializeComponent();
            SourceIDTextbox.Text = item.ma;
            SourceNameTextbox.Text = item.ten;
            SourceAddressTextbox.Text = item.diachi;
            SourceLinkTextbox.Text = item.link;
            value = item;
        }

        bool InputCheck()
        {
            if (SourceNameTextbox.Text == "") { MessageBox.Show("Vui lòng nhập tên nguồn!"); return false; }
            if (SourceAddressTextbox.Text == "") { MessageBox.Show("Vui lòng nhập địa chỉ nguồn!"); return false; }
            if (SourceLinkTextbox.Text == "") { MessageBox.Show("Vui lòng nhập link nguồn!"); return false; }
            return true;
        }

        private void SourceUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!InputCheck()) return;
            
            value.ten = SourceNameTextbox.Text;
            value.diachi = SourceAddressTextbox.Text;
            value.link = SourceLinkTextbox.Text;
            ischange = true;
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ischange = false;
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
