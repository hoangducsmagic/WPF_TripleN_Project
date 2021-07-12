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
    /// Interaction logic for AnoucementDialog.xaml
    /// </summary>
    public partial class AnoucementDialog : Window
    {
        Anoucement item = new Anoucement();
        public AnoucementDialog(Anoucement Anoucement)
        {
            InitializeComponent();
            item = Anoucement;
            char letter = (char)34;
            IntroTextblock.Text = $"Thông báo từ nguồn nhập {item.tennguon}:";
            AnounTextblock.Text = $"{ letter}{item.noidung}{letter}";
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

       

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ImportBUS ImportBUS = new ImportBUS();
            ImportBUS.AnounDelete(item.manguon);
        }
    }
}
