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
    /// Interaction logic for AnounAddDialog.xaml
    /// </summary>
    public partial class AnounAddDialog : Window
    {
        public static DateTime date;
        public static string value;

        public AnounAddDialog()
        {
            InitializeComponent();
            
        }

        bool InputCheck()
        {
            try { DateTime.Parse(DatePicker.Text); } catch (Exception) { MessageBox.Show("Ngày không hợp lệ!"); return false; }
            if (DatePicker.SelectedDate == null) { MessageBox.Show("Vui lòng chọn ngày!"); return false; }
            if (AnounTextbox.Text == "")  { MessageBox.Show("Vui lòng nhập nội dung thông báo!"); return false; }

            return true;
        }

        private void AnounAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!InputCheck()) return;

            date = (DateTime)DatePicker.SelectedDate;
            value = AnounTextbox.Text;
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            value = "";
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
