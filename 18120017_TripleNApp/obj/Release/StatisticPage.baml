   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf (    "_18120017_TripleNApp.StatisticPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  $	��650��  N� 
Background  �#ddffcf N� Title$ StatisticPage�� � 	Resources )   #_18120017_TripleNApp.MoneyConverter   MoneyConverter-   '_18120017_TripleNApp.RankColorConverter  RankColorConverter,   &_18120017_TripleNApp.RankIconConverter  RankIconConverter��%-   &	        &	      &	 
           .���� $
��Auto=�.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.��� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��THỐNG KÊ��$��Center=��� -   $��NothingToShowTextblock��$��Center=�$��0 30 0 0q�$��
Bree Serif)�$��30(�$/��)Không có dữ liệu để thống kê!��$y�	Collapsed=��� -   $��ContentPanel��.+��  � ColumnDefinitions �� $��* ��� $��* �.+��� $��0��$��10 20 10 10q�.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� $��Năm: ��$��20(�$
��Bold"�$��Center=��� -   $��YearCombobox��$��Center=� & "MaterialDesignFloatingHintComboBox#��[ $��	5 -12 0 0q�$��80��$��20(����� .R��� ���� #  LiveCharts.Wpf.CartesianChart  -   $��ColumnChart��$	��350��$��20q�&   LiveCharts.Wpf.Charts.Base.Chart   DataTooltip Z�    AxisX   LiveCharts.Wpf.Axis     Labels �� *	MonthList+�� $&�� Tổng doanh thu qua các tháng��$��20(�$��Italic$�$��Center=��� $��1��$��10 20 10 10q�.+��� $ 
Horizontal=�$��Center=�.+��� $��Tháng: ��$��20(�$
��Bold"�$��Center=��� -   $��MonthCombobox��$��Center=�#��[ $��	5 -12 0 0q�$��60��$��20(����� .R��� ���� � $��20q�.+��� -   $��EmptyPie��$9��3Tháng này không bán được sản phẩm nào.��$��20(�$��Center=�$y�	Collapsed=�  LiveCharts.Wpf.PieChart  -   $��PieChart��$	��350��	   LegendLocation$	 Bottom=��� $)��#Doanh thu sản phẩm trong tháng��$��20(�$��Italic$�$��Center=�� $��	0 20 0 10q�.+��� $��1q�
�������$��Center=��� $��DANH SÁCH KHÁCH HÀNG��$��30(�$��
Bree Serif)�$
��Bold"�
��� d ����#ddffcf$��Center=�� $
��1045��$��Center=�$��0 40 0 0q� �� $��25 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��ImagesResource/gold.png��$��40��$y�Hidden=��� $��1��$	��STT��$��20(�$��Center=�$
��Bold"��� $��2��$��Tên khách hàng��$��20(�$��Center=�$
��Bold"��� $��3��$��Điện thoại��$��20(�$��Center=�$
��Bold"��� $��4��$��Số lần mua hàng��$��20(�$��Center=�$
��Bold"��� $��5��$��Tổng tiền thanh toán��$��20(�$��Center=�$
��Bold"��� -   $��CustomerListview��
 J� IsHitTestVisible
 .  $��0 0 0 30q�$��Center=�$
��Auto=���.  ���� .R��� ���� .R��� .+��� $��1q�
�������� $
��1045��$��Center=����� *Item1+ �� 	Converter# [  �� $��25 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��40��$��Right=����� *Item1+# [ �� $��1��$��Center=�$��Center=����� *Item1+�� $��2��$��Center=�$��Center=����� *	Item2.ten+�� $��3��$��Center=�$��Center=����� *	Item2.sdt+�� $��4��$��Center=�$��Center=����� *Item2.solan+�� $��5��$��Center=�$��Center=����� *Item2.tongtien+# [  