   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5      +    %_18120017_TripleNApp.SourceDetailPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:_18120017_TripleNApp     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
FontFamily$  
Bree Serif)�5
       N� FontSize$ 18(�6    N� 
Background �#ddffcf N� Title$ SourceDetailPage��5       � 	Resources 5      )   #_18120017_TripleNApp.MoneyConverter   MoneyConverter(   "_18120017_TripleNApp.DateConverter  DateConverter��%:   &	        &	        5   
   6     5   
   6   5      .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��16q�65   .��5      � .+�5      �� -   5        $��
BackButton��5      $
��Left=�5       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6.   $
��auto��6?   $
��auto��6M   5      �� 5      .+�5      �� $��	Amatic SC)�6    $
��Bold"�67   $��40(�6I   $��CHI TIẾT HÓA ĐƠN��6W   $��Center=�6o   5      5      5       � 5#   
   $��
40 30 40 5q�6   $��Center=�6#   .+�5$      �� $��1q�6   
�������$��0 10 0 0q�6<    �� CornerRadius$ 8��6N   $
��Left=�6_    �� Padding$ 10q�6z   $	��600��6�   ._�5%      �� .+�5&      �� 	 �� Orientation$	 
Horizontal=�6!   .+�5'      �� $��Mã nguồn nhập: ��6$   �� 5(      ��6$   �� *ma+5)      �� 5*      $	 
Horizontal=�6!   .+�5+      �� $��Tên nguồn nhập: ��6$   �� 5,      ��6$   �� *ten+5-      �� 5.      $	 
Horizontal=�6!   .+�5/      �� $��Địa chỉ: ��6$   �� 50      ��6$   �� *diachi+51      �� 52      $	 
Horizontal=�6!   .+�53      �� $��Link web nguồn: ��6$   �� 54      -   5        $��LinkTextblock��54   2   
 � Cursor$

 Hand��6$   
����  �$��	Underline{�56   *   ��55      �� *link+57      58      59      5;      �� 5<      ���#ddffcf$
��Bold"�6-   
��� ���$��THÔNG TIN LIÊN HỆ��6Q   $��15(�6j   $	��Top=�6x   $
��Left=�6�   $��25 0 0 0q�6�   5=      � 5?   
   $��	40 5 40 5q�6   $��Center=�6"   .+�5@      �� $��1q�6   
�������$��0 10 0 0q�6<   $ 8��6N   $
��Left=�6_   $ 10q�6z   $	��600��6�   ._�5A      �� .+�5B      �� $	 
Horizontal=�6!   .+�5C      �� $'��!Tổng sản phẩm đã nhập: ��6$   �� 5D      ��6$   �� *tongsanpham+5E      �� 5F      $	 
Horizontal=�6!   .+�5G      �� $!��Tổng tiền đã nhập: ��6$   �� 5H      ��6$   �� *
tongtien+ �� 	Converter# [  5I      5J      5K      �� 5L      ���#ddffcf$
��Bold"�6-   
��� ���$��THÔNG TIN THỐNG KÊ��6Q   $��15(�6k   $	��Top=�6y   $
��Left=�6�   $��25 0 0 0q�6�   5M      � 5P   
   -   5        $��
AnounPanel��5P   "   $��	40 5 40 5q�6   $��Center=�64   .+�5Q      �� $��1q�6   
�������$��0 10 0 0q�6<   $ 8��6N   $
��Left=�6_   $ 10q�6z   $	��600��6�   ._�5R      �� .+�5S      �� $	 
Horizontal=�6!   .+�5T      �� $��Thời gian: ��6$   �� 5U      ��6$   �� *
thoigian+# [ 5V      �� 5W      $	 
Horizontal=�6!   .+�5X      �� $��Nội dung: ��6$   �� 5Y      $
��Wrap=�6=    �� TextAlignment$ Justify=�6Q   $��	10 0 10 0q�6i   ��6$   �� *	noidung+6i   5Z      5[      5\      �� 5]      ���#ddffcf$
��Bold"�6-   
��� ���$��THÔNG BÁO NHẬP HÀNG��6Q   $��15(�6l   $	��Top=�6z   $
��Left=�6�   $��25 0 0 0q�6�   5^      �� 5`   
   $	 
Horizontal=�6   $��20q�6.   $��Center=�6:   .+�5a      �� -   5        $��AnounAddButton��5a   .   $��Thêm thông báo��6   $��10q�6D   6P   �� 5b      -   5        $��AnounDeleteButton��5b   -   $��Xóa thông báo��6   $��10q�6F   6R   �� 5c      -   5        $��SouceUpdateButton��5c   2   $��Cập nhật thông tin��6   $��10q�6K   6W   �� 5d      -   5        $��StatisticDeleteButton��5d   ,   $��Xóa thống kê��6   $��10q�6I   6U   5f      5h      5i      