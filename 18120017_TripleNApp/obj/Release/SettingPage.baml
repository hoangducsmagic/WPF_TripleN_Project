   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  &     _18120017_TripleNApp.SettingPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#ddffcf N� Title$ SettingPage��.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.��� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��THÊM SẢN PHẨM��$��Center=�� $��
40 30 40 5q�.+��� $��1q�
�������$��0 10 0 0q� �� CornerRadius$ 8��$
��Left=� �� Padding$ 10q�$	��500��._��� .+���  �� Orientation$ 
Horizontal=�$��20q�.+��� $%��Số sản phẩm mỗi trang: ��$��20(�$
��Bold"�$��Center=��� -   $��ProductPerPageTextbox��$��20(�$��50��$��5 0 0 0q��� ���#ddffcf$
��Bold"�
��� ���$��PHÂN TRANG��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��	40 5 40 5q�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$ 10q�$	��500��._��� .+��� $ 
Horizontal=�$��	20 0 20 0q�.+��� $��Tiêu chí: ��$��20(�$
��Bold"�$��Center=��� -   $��ProductSortByCombobox��$��Center=�$	��100�� &  "MaterialDesignFloatingHintComboBox#��[  $��	5 -12 0 0q�$��20(�.@��� .��theo tên sản phẩm�� .��theo giá bán sản phẩm�� .��+)theo số lượng sản phẩm đã bán�� .��$"theo số lượng hàng tồn kho�� $ 
Horizontal=�$��	20 0 20 0q�.+��� $��Thứ tự: ��$��20(�$
��Bold"�$��Center=��� -   $��ProductOrderCombobox��$��Center=�$	��100��#��[  $��	5 -12 0 0q�$��20(�.@��� .��tăng dần�� .��giảm dần�� ���#ddffcf$
��Bold"�
��� ���$��SẮP XẾP SẢN PHẨM��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��	40 5 40 5q�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$ 10q�$	��500��._��� .+��� $ 
Horizontal=�$��	20 0 20 0q�.+��� $��Tiêu chí: ��$��20(�$
��Bold"�$��Center=��� -   $��BillSortByCombobox��$��Center=�$	��100��#��[  $��	5 -12 0 0q�$��20(�.@��� .��theo tên khách hàng�� .��theo giá trị đơn hàng�� .��theo ngày lập đơn hàng�� $ 
Horizontal=�$��	20 0 20 0q�.+��� $��Thứ tự: ��$��20(�$
��Bold"�$��Center=��� -   $��BillOrderCombobox��$��Center=�$	��100��#��[  $��	5 -12 0 0q�$��20(�.@��� .��tăng dần�� .��giảm dần�� ���#ddffcf$
��Bold"�
��� ���$��SẮP XẾP ĐƠN HÀNG��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��	40 5 40 5q�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$ 10q�$	��500��._��� .+��� $ 
Horizontal=�$��	20 0 20 0q�.+��� $��Tiêu chí: ��$��20(�$
��Bold"�$��Center=��� -   $��SourceSortByCombobox��$��Center=�$	��100��#��[  $��	5 -12 0 0q�$��20(�.@��� .��theo tên nguồn nhập�� .��%#theo tổng số tiền đã nhập�� .��theo mục yêu thích�� $ 
Horizontal=�$��	20 0 20 0q�.+��� $��Thứ tự: ��$��20(�$
��Bold"�$��Center=��� -   $��SourceOrderCombobox��$��Center=�$	��100��#��[  $��	5 -12 0 0q�$��20(�.@��� .��tăng dần�� .��giảm dần�� ���#ddffcf$
��Bold"�
��� ���$&�� SẮP XẾP NGUỒN NHẬP HÀNG��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�