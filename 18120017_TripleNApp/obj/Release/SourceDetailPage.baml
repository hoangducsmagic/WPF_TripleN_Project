   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  +    %_18120017_TripleNApp.SourceDetailPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
FontFamily$  
Bree Serif)� N� FontSize$ 18(� N� 
Background �#ddffcf N� Title$ SourceDetailPage�� � 	Resources )   #_18120017_TripleNApp.MoneyConverter   MoneyConverter(   "_18120017_TripleNApp.DateConverter  DateConverter��%   &	        &	          .���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.��� .+��� -   $��
BackButton��$
��Left=� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�$
��auto��$
��auto���� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��CHI TIẾT HÓA ĐƠN��$��Center=�� $��
40 30 40 5q�$��Center=�.+��� $��1q�
�������$��0 10 0 0q� �� CornerRadius$ 8��$
��Left=� �� Padding$ 10q�$	��600��._��� .+��� 	 �� Orientation$	 
Horizontal=�.+��� $��Mã nguồn nhập: ���� ���� *ma+�� $	 
Horizontal=�.+��� $��Tên nguồn nhập: ���� ���� *ten+�� $	 
Horizontal=�.+��� $��Địa chỉ: ���� ���� *diachi+�� $	 
Horizontal=�.+��� $��Link web nguồn: ���� -   $��LinkTextblock��
 � Cursor$

 Hand��
����  �$��	Underline{����� *link+�� ���#ddffcf$
��Bold"�
��� ���$��THÔNG TIN LIÊN HỆ��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��	40 5 40 5q�$��Center=�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$ 10q�$	��600��._��� .+��� $	 
Horizontal=�.+��� $'��!Tổng sản phẩm đã nhập: ���� ���� *tongsanpham+�� $	 
Horizontal=�.+��� $!��Tổng tiền đã nhập: ���� ���� *
tongtien+ �� 	Converter# [  �� ���#ddffcf$
��Bold"�
��� ���$��THÔNG TIN THỐNG KÊ��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� -   $��
AnounPanel��$��	40 5 40 5q�$��Center=�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$ 10q�$	��600��._��� .+��� $	 
Horizontal=�.+��� $��Thời gian: ���� ���� *
thoigian+# [ �� $	 
Horizontal=�.+��� $��Nội dung: ���� $
��Wrap=� �� TextAlignment$ Justify=�$��	10 0 10 0q����� *	noidung+�� ���#ddffcf$
��Bold"�
��� ���$��THÔNG BÁO NHẬP HÀNG��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q��� $	 
Horizontal=�$��20q�$��Center=�.+��� -   $��AnounAddButton��$��Thêm thông báo��$��10q��� -   $��AnounDeleteButton��$��Xóa thông báo��$��10q��� -   $��SouceUpdateButton��$��Cập nhật thông tin��$��10q��� -   $��StatisticDeleteButton��$��Xóa thống kê��$��10q�