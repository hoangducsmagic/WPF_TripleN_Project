   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  '    !_18120017_TripleNApp.BillListPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#ddffcf N� Title$ BillListPage�� � 	Resources )   #_18120017_TripleNApp.MoneyConverter   MoneyConverter(   "_18120017_TripleNApp.DateConverter  DateConverter��%   &	        &	          .���� $
��Auto=�.���� .+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.���� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��DANH SÁCH HÓA ĐƠN��$��Center=���  �� Orientation$ 
Horizontal=�$��Center=�.+�  -   $��
SearchZone��$ Standard=�$	��400��$��8 4 8 4q�   CornerRadius$ 2�� K� ZIndex$ 1��$��16 0 0 0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�.���  � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� -   $��SearchButton��  MaterialDesignToolButton#���  .��'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Magnify=�
 J� Opacity$	
 .56Q��� -   $��SearchTextBox��$��1��$��8 0 0 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$) #Nhập tên khách hàng cần tìm��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��200��$��Center=��� -   $��BillAddButton��$��30 0 0 0q�
���/���.��  $
	 Plus=�$��30��$��30��$��Center=�
���   ��� -   $��NothingToShowTextblock��$��Center=�$��0 30 0 0q�$��
Bree Serif)�$��30(�$5��/Không có đơn hàng nào để hiển thị!��$y�	Collapsed=��� -   $��NotExistTextblock��$%��Không tìm thấy đơn hàng!��$y�	Collapsed=�$��
Bree Serif)�$��30(�$��Center=�$��0 30 0 0q��� -   $��ContentPanel��.+�� $
��1045��$��Center=�$��0 40 0 0q� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��
Hóa đơn��$��20(�$��Center=�$
��Bold"��� $��1��$��Khách hàng��$��20(�$��Center=�$
��Bold"��� $��2��$��Ngày lập��$��20(�$��Center=�$
��Bold"��� $��3��$��Thành tiền��$��20(�$��Center=�$
��Bold"��� -   $��BillListview��$��Center=�$
��Auto=���.  ���� .R��� ���� .R��� .+��� $��1q�
�������� $
��1045��$��Center=� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��0��$��Center=�$��Center=����� *ma+�� $��1��$��Center=�$��Center=����� *khachhang.ten+�� $��2��$��Center=�$��Center=����� *	ngaylap+ �� 	Converter# [ �� $��3��$��Center=�$��Center=����� *	thanhtien+# [  �� $��BillDeleteButton��-	   $��4��$
��Xóa��$��Center=�$��Center=�