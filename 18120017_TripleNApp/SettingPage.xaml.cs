using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SettingPage.xaml
    /// </summary>
    public partial class SettingPage : Page
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public SettingPage()
        {
            InitializeComponent();
            ProductPerPageTextbox.Text = config.AppSettings.Settings["ProductPerPage"].Value;
            
            ProductSortByCombobox.SelectedIndex = int.Parse(config.AppSettings.Settings["ProductSortBy"].Value)-1;
            ProductOrderCombobox.SelectedIndex = int.Parse(config.AppSettings.Settings["ProductOrder"].Value)-1;
           
            BillSortByCombobox.SelectedIndex = int.Parse(config.AppSettings.Settings["BillSortBy"].Value) - 1;
            BillOrderCombobox.SelectedIndex = int.Parse(config.AppSettings.Settings["BillOrder"].Value) - 1;
            
            SourceSortByCombobox.SelectedIndex = int.Parse(config.AppSettings.Settings["SourceSortBy"].Value) - 1;
            SourceOrderCombobox.SelectedIndex = int.Parse(config.AppSettings.Settings["SourceOrder"].Value) - 1;
        }

        private void ProductPerPageTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ProductPerPageTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ProductPerPageTextbox.Text == "") return;
            int tam = int.Parse(ProductPerPageTextbox.Text);
            if (tam <= 0) return;
            config.AppSettings.Settings["ProductPerPage"].Value = tam.ToString();
            config.Save(ConfigurationSaveMode.Minimal);
            
        }

        private void ProductSortByCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            config.AppSettings.Settings["ProductSortBy"].Value = (ProductSortByCombobox.SelectedIndex+1).ToString();
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void ProductOrderCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            config.AppSettings.Settings["ProductOrder"].Value = (ProductOrderCombobox.SelectedIndex + 1).ToString();
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void BillSortByCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            config.AppSettings.Settings["BillSortBy"].Value = (BillSortByCombobox.SelectedIndex + 1).ToString();
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void BillOrderCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            config.AppSettings.Settings["BillOrder"].Value = (BillOrderCombobox.SelectedIndex + 1).ToString();
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void SourceSortByCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            config.AppSettings.Settings["SourceSortBy"].Value = (SourceSortByCombobox.SelectedIndex + 1).ToString();
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void SourceOrderCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            config.AppSettings.Settings["SourceOrder"].Value = (SourceOrderCombobox.SelectedIndex + 1).ToString();
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}
