   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  ,    &_18120017_TripleNApp.ProductDetailPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#ddffcf N� Title$ ProductDetailPage�� � 	Resources *   $_18120017_TripleNApp.BitmapConverter   BitmapConverter)   #_18120017_TripleNApp.MoneyConverter  MoneyConverter��%   &	        &	          .���� $
��Auto=�.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��10q�.��� .+��� -   $��
BackButton��$
��Left=�$��16 0 0 0q� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�$
��auto��$
��auto���� $��	Amatic SC)�$
��Bold"�$��40(�$��CHI TIẾT SẢN PHẨM��$��Center=�� $��30 15 30 10q� � ColumnDefinitions �� $��4* ��� $��6* �.+��� $��0��$��10q�.+�A� $	��350��$	��350������  �� Color$
 Gray�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 1Q�	   
BlurRadius$	 5Q����� -   Avt��
 j� Stretch$
 UniformToFill=��� -   $��PicListview��$��0 20 0 0q����� .R�� ���� .R��� $��80������ *pic+ �� 	Converter# [  �� $��1��$��10q�.+��� $��
Bree Serif)�
���  ��$��45(�$
��Bold"�$��10q����� *ten+��  �� Orientation$ 
Horizontal=�$��0 0 0 10q�.+��� $��Mã sản phẩm: ��$��
Bree Serif)�
�������$��22(�$��
10 10 0 10q��� $��
Bree Serif)�
�������$��22(�$��
0 10 10 10q����� *ma+�� $
��Wrap=� �� TextAlignment$ Justify=�$��15(�$	��130��$��10q����� *mota+� .+��� $��1q�
�������$��Center=��� $��Thông tin sản phẩm��$��15(�
�����p����#ddffcf$��Center=��  �� $��* ��� $��* �.+��� $��0��.+��� $ 
Horizontal=�$��5q�.+�  $ Category=�$��Center=�
���  ��$��0 0 5 0q��� $��Loại sản phẩm: ��
���  ��$��15(��� 
���  ��$��15(����� *	tenloai+�� $ 
Horizontal=�$��5q�.+�  $ Resize=�$��Center=�
���  ��$��0 0 5 0q��� $��Kích cỡ: ��
���  ��$��15(�$��Center=��� -   $��SizeListview�� J� IsHitTestVisible .  ���� .R�� ���� .R��� $ 
Horizontal=�.+��� 
���  ��$��15(����� *size+�� $��  ��
���  ��$��15(�$��Center=��� $ 
Horizontal=�$��5q�.+�  $ Color=�$��Center=�
���  ��$��0 0 5 0q��� $��Màu sắc: ��
���  ��$��15(�$��Center=��� -   $��ColorListview�� .  ���� .R�� ���� .R��� $ 
Horizontal=�.+��� $��  ��
���  ��$��15(�$��Center=�  $ SquareRounded=�$��20��$��20��$��Center=����� *color+�� $ 
Horizontal=�$��5q�.+�  $ Coins=�$��Center=�
���  ��$��0 0 5 0q��� $��Đơn giá nhập: ��
���  ��$��15(��� 
���  ��$��15(����� *	gianhap+# [ �� $ 
Horizontal=�$��5q�.+�  $ Coins=�$��Center=�
���  ��$��0 0 5 0q��� $��Đơn giá bán: ��
���  ��$��15(��� 
���  ��$��15(����� *giaban+# [ �� $ 
Horizontal=�$��5q�.+�  $
 Cash=�$��Center=�
���  ��$��0 0 5 0q��� $��Chi môi giới: ��
���  ��$��15(��� 
���  ��$��15(����� *
phantram+�� $�� %��
���  ��$��15(��� $��1��.+��� $ 
Horizontal=�$��5q�.+�  $ Weight=�$��Center=�
���  ��$��0 0 5 0q��� $��Trọng lượng: ��
���  ��$��15(��� 
���  ��$��15(����� *
trongluong+�� $�� gram��
���  ��$��15(��� $ 
Horizontal=�$��5q�.+�  $ Counter=�$��Center=�
���  ��$��0 0 5 0q��� $��Số lượng bán: ��
���  ��$��15(��� 
���  ��$��15(����� *daban+�� $ 
Horizontal=�$��5q�.+�  $ Counter=�$��Center=�
���  ��$��0 0 5 0q��� $��Số lượng tồn: ��
���  ��$��15(��� 
���  ��$��15(����� *tonkho+�� $ 
Horizontal=�$��5q�.+�  $ LocalGroceryStore=�$��Center=�
���  ��$��0 0 5 0q��� $)��#Số lượng hàng tối thiểu: ��
���  ��$��15(��� $��4��
���  ��$��15(��� $ 
Horizontal=�$��5q�.+�  $ Truck=�$��Center=�
���  ��$��0 0 5 0q��� $��Nguồn nhập: ��
���  ��$��15(��� 
���  ��$��15(����� *	manguon+�� $ 
Horizontal=�$��Center=�$��0 10 0 0q�.+��� -   $��UpdateButton��$��Cập nhật sản phẩm��$��10q��� -   $��DeleteButton��$��Xóa sản phẩm��$��10q�