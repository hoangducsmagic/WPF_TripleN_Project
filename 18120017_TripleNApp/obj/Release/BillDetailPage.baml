   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  )    #_18120017_TripleNApp.BillDetailPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#ddffcf N� Title$ BillDetailPage�� � 	Resources )   #_18120017_TripleNApp.MoneyConverter   MoneyConverter(   "_18120017_TripleNApp.DateConverter  DateConverter��%   &	        &	          .���� $
��Auto=�.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.��� .+��� -   $��
BackButton��$
��Left=� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�$
��auto��$
��auto���� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��CHI TIẾT HÓA ĐƠN��$��Center=��� $��Center=�$��0 15 0 0q�.+���  �� Orientation$ 
Horizontal=�$��5q�$
��Left=�.+�  $ Notebook=�$��0 0 5 0q�$��Center=�$��25��$��25��
���  ���� $��Mã hóa đơn: ��$��
Bree Serif)�$��25(�
���  ��$��Center=��� $��
Bree Serif)�$��25(�
���  ��$��Center=����� *ma+�� $ 
Horizontal=�$��5q�$
��Left=�.+�  $ Calendar=�$��0 0 5 0q�$��Center=�$��25��$��25��
���  ���� $��Ngày lập hóa đơn: ��$��
Bree Serif)�$��25(�
���  ��$��Center=��� $��
Bree Serif)�$��25(�
���  ��$��Center=����� *	ngaylap+ �� 	Converter# [ �� $ 
Horizontal=�$��5q�$
��Left=�.+�  $ Truck=�$��0 0 5 0q�$��Center=�$��25��$��25��
���  ���� $��Phí vận chuyển: ��$��
Bree Serif)�$��25(�
���  ��$��Center=��� $��
Bree Serif)�$��25(�
���  ��$��Center=����� *	vanchuyen+# [  �� $ 
Horizontal=�$��5q�$
��Left=�.+�  $ Coins=�$��0 0 5 0q�$��Center=�$��25��$��25��
���  ���� $��Tổng thành tiền: ��$��
Bree Serif)�$��25(�
���  ��$��Center=��� $��
Bree Serif)�$��25(�
���  ��$��Center=����� *	thanhtien+# [  � $��
40 5 40 10q�.+��� $��1q�
�������$��0 10 0 0q� �� CornerRadius$ 8��$
��Left=� �� Padding$ 10q�$	��300��._��� .+��� $ 
Horizontal=�$��25 5 5 0q�.+��� $��Tên khách hàng: ��$
��Bold"��� ���� *khachhang.ten+�� $ 
Horizontal=�$��25 5 5 0q�.+��� $��Số điện thoại: ��$
��Bold"��� ���� *khachhang.sdt+�� $ 
Horizontal=�$��25 5 5 0q�.+��� $��Địa chỉ: ��$
��Bold"��� ���� *khachhang.diachi+�� ���#ddffcf$
��Bold"�$��Thông tin khách hàng��
��� ���$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��	40 5 40 5q�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$ 10q�$	��300��._��� .+�� $
��1100��$��0 0 0 20q�$��Center=�	 � ColumnDefinitions	 �� $��2* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��Tên sản phẩm��$��Center=�$
��Bold"��� $��1��$��Mã sản phẩm��$��Center=�$
��Bold"��� $��2��$��Số lượng��$��Center=�$
��Bold"��� $��3��$��
Đơn giá��$��Center=�$
��Bold"��� $��4��$��Thành tiền��$��Center=�$
��Bold"��� -   $��ProductListview��$��Center=�
 J� IsHitTestVisible
 .  ���� .R��� ���� .R��� .+��� $��1q�
����+��� $
��1100��	 �� $��2* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��Center=����� *
tensanpham+�� $��1��$��Center=����� *	masanpham+�� $��2��$��Center=����� *	soluong+�� $��3��$��Center=����� *dongia+# [  �� $��4��$��Center=����� *	thanhtien+# [  �� ���#ddffcf$
��Bold"�
��� ���$��Danh sách sản phẩm��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��
40 5 40 10q�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$ 10q�$	��300��._��� .+�� $	��750��$��Center=�$��0 0 0 20q�	 �� $��* ��� $��* �.+��� $��0��$��Loại khuyến mãi��$��Center=�$
��Bold"��� $��1��$��Số tiền��$��Center=�$
��Bold"��� -   $��DiscountListview��
 .  $��Center=����� .R��� ���� .R��� .+��� $��1q�
����+��� $	��750��	 �� $��* ��� $��* �.+��� $��0��$��Center=����� *ten+�� $��1��$��Center=����� *sotien+# [  �� ���#ddffcf$
��Bold"�
��� ���$��Các khuyến mãi��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�