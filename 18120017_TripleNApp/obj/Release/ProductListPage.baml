   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  *    $_18120017_TripleNApp.ProductListPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#ddffcf N� Title$ ProductListPage�� � 	Resources *   $_18120017_TripleNApp.BitmapConverter   BitmapConverter)   #_18120017_TripleNApp.MoneyConverter  MoneyConverter.   (_18120017_TripleNApp.LimitReachConverter  LimitReachConverter��%-   &	        &	      &	 
           .���� $
��Auto=�.���  � ColumnDefinitions �� $��2* ��� $
��auto ��� $��8* �.+��� $��0��.+��� $��Loại sản phẩm��$��Center=�$
��Bold"�$��15(�$��	0 10 0 10q�R� -   $��TypeTreeview��$��	-35 0 0 0q�$
��Auto=�$	��610��$
��Auto=����� .R�Q� ����  �� Orientation$ 
Horizontal=�.+��� ���� *ten+�� $�� (���� ���� *	soluong+�� $��)��.@��� $��TypeListview��-   ���� *ProductList+���� .R��� ���� .R��� ���� *ten+�� $��1��$��1 0 0 0q�
��������� $��2��.+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��16q�.���� .+��� $��	Amatic SC)�$
��Bold"�$��40(�$��DANH SÁCH SẢN PHẨM��$��Center=��  �� $��6* ��� $
��auto ��� $��3* �.+�  -   $��
SearchZone��$ Standard=�$��0��$	��400��$��8 4 8 4q�   CornerRadius$ 2�� K� ZIndex$ 1��$��16 0 0 0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�.���  �� $
��Auto ��� $��* ��� $
��Auto �.+��� -   $��SearchButton��  MaterialDesignToolButton#���  .��'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Magnify=�
 J� Opacity$	
 .56Q��� -   $��SearchTextBox��$��1��$��8 0 0 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$) #Nhập tên sản phầm cần tìm��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��200��$��Center=��� -   $��ProductAddButton��$��1��
���/���.��  $
	 Plus=�$��30��$��30��$��Center=�
���   ��� -   $��PageNavigationPanel��$ 
Horizontal=�$��2��$��Center=�.+��� -   $��PreviousPageButton��$��Right=� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ .��  $	 NavigateBefore=�$
��auto��$
��auto���� -	   $��CurrentPageTextBox�� � Cursor$
 Hand��$��60��$��0q� �� TextAlignment$ Center=�$��Center=�$��20(�$��5 0 5 0q� �� SelectionBrush
 �   ����	#FF673AB7���	#DDFFFFFF�� -
   $��NextPageButton��$��Right=�#��[ .��  $	 NavigateNext=�$
��auto��$
��auto���� -   $��NotExistTextblock��$+��%Không tìm thấy sản phẩm nào!��$y�	Collapsed=�$��
Bree Serif)�$��30(�$��Center=�$��0 30 0 0q��� -   $��NothingToShowTextblock��$��
Bree Serif)�$��30(�$��Center=�$��0 30 0 0q�$6��0Không có sản phẩm nào để hiển thị!��$y�	Collapsed=��� -   $��ProductListview����.  $��20q�$��Disabled=�$��Center=����� .R�� ���� .R��� $��1q� �� CornerRadius$ 10�� �� Padding$ 10q�
�������$	��210��$	��340��._�]� .+��� $	��Top=�.+�� .+�A� $	��180��$	��180������  �� Color$
 Gray�� J� Effect 3	  -System.Windows.Media.Effects.DropShadowEffect	   	  ShadowDepth$ 1Q� 	  
BlurRadius$ 5Q�����  j� Stretch$ UniformToFill=� �� ImageSource �� *avt+ �� 	Converter# [  A� $	��180��$	��180������ $
 Gray�� 	  $ 1Q�$ 5Q����� $ UniformToFill=� �� *
nhapthem+# [ �� $
��Wrap=�$��
Bree Serif)�$��Center=�
���  ��$��15(�$��10q�$��Center=����� *ten+� $��Bottom=�$��Bottom=�.+��� $��Bottom=�$��Bottom=�$
��Left=�.+��� $ 
Horizontal=�.+��� $��Đã bán: ���� ���� *daban+�� $ 
Horizontal=�.+��� $��Tồn kho: ���� ���� *tonkho+'
  !MaterialDesignThemes.Wpf.PopupBox
  $��Bottom=�$��Bottom=�$��Right=�$��2 0 2 0q� 
  PopupContent. �� .+��� $��ProductUpdateButton��-   $��Cập nhật sản phẩm��$��Center=��� $��ProductDeleteButton��-   $��Xóa sản phẩm��$��Center=��� $��Bottom=�$��2q�$ 3q�$ 5��
��� � �$��Center=�$��Bottom=�$��5q�._��� $��12(�$
��Bold"�
��� � �$��Center=����� *giaban+# [ 