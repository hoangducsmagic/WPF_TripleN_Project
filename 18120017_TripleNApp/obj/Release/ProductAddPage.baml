   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  )    #_18120017_TripleNApp.ProductAddPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�$	��650�� N� 
Background �#ddffcf N� Title$ ProductAddPage�� � 	Resources )   #_18120017_TripleNApp.MoneyConverter  MoneyConverter��%   &	         .���� $
��Auto=�.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.��� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��THÊM SẢN PHẨM��$��Center=�� $��30q� � ColumnDefinitions �� $��4* ��� $��6* �.+��� $��0��.+��� $��1q�
����p��$	��420��._��� -   $��PicListview�� �� SelectionMode$ Multiple=�$��Disabled=�$	��300��$	��410��$	��Top=����� .R�� ���� .R��� $	��120��$	��120��$��Uniform=����� *path+��  �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $��PicAddButton��$��Thêm ảnh��$��10q��� -   $��PicDelButton��$��
Xóa ảnh��$��10q��� $��1q�
����p��$	��420��._��� -   $��ColorListview��$ Multiple=�$��Disabled=�$	��100��$	��410��$	��Top=����� .R�� ���� .R�'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 SquareRounded=�$��40��$��40��$��Center=����� *color+�� $ 
Horizontal=�$��Center=�.+�#  Xceed.Wpf.Toolkit.ColorPicker  -   $��ColorPicker��$��60��$��35���� -   $��ColorAddButton��$��
Thêm màu��$��10q��� -   $��ColorDelButton��$��	Xóa màu��$��10q��� $��1q�
����p��$	��420��._��� -   $��SizeListview��$ Multiple=�$��Disabled=�$	��100��$	��410��$	��Top=����� .R�� ���� .R��� $��2q�
 �� Padding$
 3q� �� CornerRadius$ 5��
��� � �$��5q�._��� $��20(�$
��Bold"�
��� � �$��Center=����� *size+�� $ 
Horizontal=�$��Center=�.+��� -	   $��SizeTextbox��$��60�� % !MaterialDesignFloatingHintTextBox#��[ 
���  ��$��15(��� -
   $��SizeAddButton��$��Thêm kích thước��$��10q��� -   $��SizeDelButton��$��Xóa kích thước��$��10q��� $��1��$��10q�.+��� -   $��ProductNameTextbox��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên sản phẩm��$��
Bree Serif)�
���  ��$��50(�$
��Bold"�  MaterialDesignTextBox#��[ $��10q��� $ 
Horizontal=�$��0 0 0 10q�.+��� $��Mã sản phẩm: ��$��
Bree Serif)�
�������$��25(�$��
10 10 0 10q��� -   $��ProductIDTextbox��$��
Bree Serif)�
�������$��25(�$��
0 10 10 10q��� -   $��ProductDescriptionTextbox�� ! MaterialDesignOutlinedTextBox#��[ $��10q�$	��Top=�$	��200�� �� AcceptsReturn .  �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=�$ Mô tả sản phẩm��� .+��� $��1q�
�������$��Center=��� $��Thông tin sản phẩm��$��15(�
�����p����#ddffcf$��Center=��  �� $��6* ��� $��4* �.+��� $��0��.+��� $ 
Horizontal=�$��5q�.+�  $	 Category=�$��Center=�
���  ��$��0 0 5 0q��� $��Loại sản phẩm: ��
���  ��$��15(�$��Center=��� -   $��TypeCombobox��$��Center=� & "MaterialDesignFloatingHintComboBox#��[ $	��150��$��Center=����� .R��� 
���  ��$��15(����� *ten+�� -   $��TypeAddButton��$��Center=�$��Thêm loại��$��10q��� $ 
Horizontal=�$��5q�.+�  $	 Coins=�$��Center=�
���  ��$��0 0 5 0q��� $#��Đơn giá nhập (đồng): ��
���  ��$��15(�$��Center=��� -   $��ImportPriceTextbox��$	��150��#��[ 
���  ��$��15(��� $ 
Horizontal=�$��5q�.+�  $	 Coins=�$��Center=�
���  ��$��0 0 5 0q��� $!��Đơn giá bán (đồng): ��
���  ��$��15(�$��Center=��� -   $��SellPriceTextbox��$	��150��#��[ 
���  ��$��15(��� $ 
Horizontal=�$��5q�.+�  $	 Truck=�$��Center=�
���  ��$��0 0 5 0q��� $��Nguồn nhập: ��
���  ��$��15(�$��Center=��� -   $��SourceCombobox��$��Center=�#��[ $	��150��$��Center=����� .R��� 
���  ��$��15(����� *ten+�� $��1��.+��� $ 
Horizontal=�$��5q�.+�  $
	 Cash=�$��Center=�
���  ��$��0 0 5 0q��� $��Chi môi giới (%): ��
���  ��$��15(�$��Center=��� -   $��PercentTextbox��$	��150��#��[ 
���  ��$��15(��� $ 
Horizontal=�$��5q�.+�  $	 Weight=�$��Center=�
���  ��$��0 0 5 0q��� $��Trọng lượng (gram): ��
���  ��$��15(�$��Center=��� -   $��WeightTextbox��$	��150��#��[ 
���  ��$��15(��� $ 
Horizontal=�$��5q�.+�  $	 Counter=�$��Center=�
���  ��$��0 0 5 0q��� $��Số lượng tồn: ��
���  ��$��15(�$��Center=��� -   $��AmountTextbox��$	��150��#��[ 
���  ��$��15(��� $ 
Horizontal=�$��5q�.+�  $	 LocalGroceryStore=�$��Center=�
���  ��$��0 0 5 0q��� $)��#Số lượng hàng tối thiểu: ��
���  ��$��15(�$��Center=��� -   $��MinimumTextbox��$	��150��#��[ 
���  ��$��15(��� $ 
Horizontal=�$��Center=�$��0 10 0 0q�.+��� -   $��ProductAddButton��$��Thêm sản phẩm��$��10q��� -   $��
BackButton��$��
Quay lại��$��10q�