using LiveCharts;
using LiveCharts.Wpf;
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
    /// Interaction logic for StatisticPage.xaml
    /// </summary>
    public partial class StatisticPage : Page
    {
        Statistic Statistic = new Statistic();

        int thismonth, thisyear;
        public string[] MonthList { get; set; } = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public int[] monthlist { get; set; } = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        List<int> YearList = new List<int>();

        

        public StatisticPage()
        {
            InitializeComponent();
            YearList = Statistic.GetYearList();
           
            YearCombobox.ItemsSource = YearList;
            MonthCombobox.ItemsSource = monthlist;
            YearCombobox.SelectedIndex = YearList.Count() - 1;
            MonthCombobox.SelectedIndex = 0;

            ColumnAnalization();
            PieAnalization();
        }

        private void MonthCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (thisyear != 0 && thismonth != 0)
                PieAnalization();
        }

        private void YearCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (thisyear != 0 && thismonth != 0)
            {
                PieAnalization();
                ColumnAnalization();
            }
        }

        void PieAnalization()
        {
            thismonth = monthlist[MonthCombobox.SelectedIndex];
            thisyear =YearList[YearCombobox.SelectedIndex];
            var StatList = Statistic.GetProductStat(thismonth,thisyear);
            

            if (StatList.Count() == 0)
            {
                EmptyPie.Visibility = Visibility.Visible;
                PieChart.Series = new SeriesCollection();
                return;
            }
            EmptyPie.Visibility = Visibility.Collapsed;
            SeriesCollection PS = new SeriesCollection();
            foreach (var item in StatList)
            {
                
                PS.Add(new PieSeries { Title = item.tensanpham, Values = new ChartValues<double> { (double)item.tongtien } });
            }
            PieChart.Series = PS;
        }

        void ColumnAnalization()
        {
            thismonth = monthlist[MonthCombobox.SelectedIndex];
            thisyear = YearList[YearCombobox.SelectedIndex];

            var StatList = Statistic.GetTotalStat(thisyear);

            var columnvalue = new ChartValues<double>();

            for (int i = 1; i <= 12; i++)
            {
                var tam = StatList.Where(c => c.thang == i).FirstOrDefault();
                if (tam == null) columnvalue.Add(0);
                else
                    columnvalue.Add((double)tam.thanhtien);
            }
            ColumnChart.Series = new SeriesCollection();
            ColumnChart.Series.Add(new ColumnSeries { Values = columnvalue });
            ColumnChart.DataContext = this;
        }
    }
}
