   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem &     _18120017_TripleNApp.BillAddPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  0sys&clr-namespace:System;assembly=mscorlib    N� Title$  BillAddPage�� N� 
Background �#ddffcf � 	Resources (   "_18120017_TripleNApp.DateConverter   DateConverter)   #_18120017_TripleNApp.MoneyConverter  MoneyConverter��%   &	        &	          .���� $
��Auto=�.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.��� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��TẠO ĐƠN HÀNG��$��Center=��� $��Center=�$��0 15 0 0q�.+���  �� Orientation$ 
Horizontal=�$��5q�$
��Left=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Notebook=�$��0 0 5 0q�$��Center=�$��25��$��25��
���  ���� $��Mã hóa đơn: ��$��
Bree Serif)�$��25(�
���  ��$��Center=��� -   $��BillIDTextbox��$	��200��$��
Bree Serif)�$��25(�
���  ��$��Center=� % !MaterialDesignFloatingHintTextBox#��[ $��	5 -11 5 5q��� -   $��GenerateIDButton��$��Tạo tự động��$��10q�$��15(�$��Center=��� $ 
Horizontal=�$��5q�$
��Left=�.+�  $ Calendar=�$��0 0 5 0q�$��Center=�$��25��$��25��
���  ���� $��Ngày lập hóa đơn: ��$��
Bree Serif)�$��25(�
���  ��$��Center=�(  "System.Windows.Controls.DatePicker  -   $��DateCreatingPicker��$��
Bree Serif)�$��25(�
���  ��$��Center=�$��	0 -16 0 0q�
 �� Now   SelectedDate# Z $	��160��$��Center=� ( $MaterialDesignFloatingHintDatePicker#��[ � $��40 40 40 20q�.+��� $��1q�
�������$��0 10 0 0q� �� CornerRadius$ 8��$
��Left=�	 �� Padding$	 10q�$	��570��._��� .+��� -   $��MemChooseButton��$"��Chọn từ khách hàng cũ��$��Center=�$��10q��� $ 
Horizontal=�$��	25 10 5 5q�.+��� $��Tên khách hàng: ��$
��Bold"��� -   $��MemNameTextbox��#��[ $	��350��$��	5 -22 0 0q��� $ 
Horizontal=�$��25 5 5 5q�.+��� $��Số điện thoại: ��$
��Bold"��� -   $��MemPhoneTextbox��#��[ $	��250��$��	5 -22 0 0q��� $ 
Horizontal=�$��25 5 5 5q�.+��� $��Địa chỉ: ��$
��Bold"��� -   $��MemAddressTextbox�� ! MaterialDesignOutlinedTextBox#��[ $��10 0 0 0q�$	��Top=�$	��120��$	��400��
 �� AcceptsReturn
 .   �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=��� ���#ddffcf$
��Bold"�$��Thông tin khách hàng��
��� ���$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��
40 0 40 20q�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$	 10q�$	��400��._��� .+�� $
��1000��$��Center=�$��	0 15 0 10q� � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��48 �.+��� $��0��$��Tên sản phẩm��$��Center=�$
��Bold"��� $��1��$��Mã sản phẩm��$��Center=�$
��Bold"��� $��2��$��Số lượng��$��Center=�$
��Bold"��� $��3��$��Đơn giá (đồng)��$��Center=�$
��Bold"��� $��4��$��Thành tiền (đồng)��$��Center=�$
��Bold"��� -   $��ProductListview��$��Center=����� .R��� ���� .R��� .+��� $��1q�
����+��� $
��1000�� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $
��auto �.+��� $��0��$��Center=����� *
tensanpham+�� $��1��$��Center=����� *	masanpham+�� $��2��$��Center=����� *	soluong+�� $��3��$��Center=����� *dongia+�� $��4��$��Center=����� *	thanhtien+�� $��ProductDeleteButton��-	   $��5��$��Center=�.��  $ Minus=��� $��1q�
����+��� $
��1000��$��Center=�
������ �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $
��auto �.+��� -
   $��ProductNameCombobox��$��0��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Chọn sản phẩm�� & "MaterialDesignFloatingHintComboBox#��[ $��Center=�$��Center=����� .R��� ���� *ten+�� -   $��ProductIDTextblock��$��1��$��Center=�$��Center=�{�.  �� -   $��ProductAmountTextbox��$��2��$ Số lượng��$��1��$��Center=�$��Center=�#��[ $��Center=��� -   $��ProductPriceTextblock��$��3��$��Center=�$��Center=�{�.  �� -   $��ProductSumTextblock��$��4��$��Center=�$��Center=�{�.  �� -   $��ProductAddButton��$��5��$��Center=�$��Center=�.��  $
 Plus=��� ���#ddffcf$
��Bold"�$��Danh sách sản phẩm��
��� ���$��15(�$	��Top=�$
��Left=�$��25 0 0 0q�� $��
40 0 40 20q�.+��� $��1q�
�������$��0 10 0 0q�$ 8��$
��Left=�$	 10q�$	��300��._��� .+�� $	��750��$��Center=�$��	0 15 0 10q� �� $��* ��� $��* ��� $��59 �.+��� $��0��$��Loại khuyến mãi��$��Center=�$
��Bold"��� $��1��$��Số tiền��$��Center=�$
��Bold"��� -   $��NoDiscountTextblock��$8��2(Chưa có khuyến mãi nào được áp dụng)��
�������$��Center=��� -   $��DiscountListview������ .R��� ���� .R��� .+��� $��1q�
����+��� $	��750�� �� $��* ��� $��* ��� $
��auto �.+��� $��0��$��Center=����� *ten+�� $��1��$��Center=����� *sotien+�� ���#ddffcf$
��Bold"�
��� ���$��Danh sách khuyến mãi��$��15(�$	��Top=�$
��Left=�$��25 0 0 0q��� $ 
Horizontal=�.+�  $ Truck=�
���  ��$��40 0 5 0q�$��25��$��25��$��Center=��� $��Phí vận chuyển: ��$��5q�$��
Bree Serif)�$��25(�
���  ���� -   $��TransportTextbox��$	��200��$��
Bree Serif)�$��25(�
���  ��$��Center=�#��[ $��	5 -11 5 5q��� $ 
Horizontal=�.+�  $ Coins=�
���  ��$��40 0 5 0q�$��25��$��25��$��Center=��� $��TỔNG THÀNH TIỀN: ��$��5q�$��
Bree Serif)�$��25(�
���  ���� -   $��TotalMoneyTextbox��$��5q�$��
Bree Serif)�$��25(�
���  ������  �� 	Converter# [ �� $ 
Horizontal=�$��Center=�.+��� -   $��BillAddButton��$��Thêm hóa đơn��$��10q��� -   $��
BackButton��$��
Quay lại��$��10q�