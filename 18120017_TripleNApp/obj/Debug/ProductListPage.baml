   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5      *    $_18120017_TripleNApp.ProductListPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:_18120017_TripleNApp     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#ddffcf N� Title$ ProductListPage��5       � 	Resources 5      *   $_18120017_TripleNApp.BitmapConverter   BitmapConverter)   #_18120017_TripleNApp.MoneyConverter  MoneyConverter.   (_18120017_TripleNApp.LimitReachConverter  LimitReachConverter��%W   &	        &	      &	 &       5   
   6      5   
   6     5   
   6$   5      .��5      �� $
��Auto=�6   .��5   
   �  � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $
��auto �6#   �� 5      $��8* �6#   .+�5      �� $��0��6   .+�5      �� $��Loại sản phẩm��6   $��Center=�61   $
��Bold"�6N   $��15(�6`   $��	0 10 0 10q�6n   R� 5      -   5        $��TypeTreeview��5      $��	-35 0 0 0q�60   $
��Auto=�6D   $	��610��6v   $
��Auto=�6�   ��5      �� 5      .R�5       Q� ��5!   "   �� 5"   &    �� Orientation$ 
Horizontal=�61   .+�5#   *   �� ��64   �� *ten+�� 5$   *   $�� (��64   �� 5%   *   ��64   �� *	soluong+�� 5&   *   $��)��64   5'   '   .@�5)   "   �� $��TypeListview��6+   -   5        ��5)   ?   �� *ProductList+��5*   &   �� 5+   *   .R�5,   .   �� 5-   +   ��5/   &   �� 50   *   .R�51   .   �� ��68   �� *ten+52   +   54   #   55      56      58      59      �� 5:      $��1��6   $��1 0 0 0q�6%   
�������6?   �� 5;      $��2��6   .+�5<      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6+   $��16q�6=   .��5=      �� .+�5>      �� $��	Amatic SC)�6$   $
��Bold"�6;   $��40(�6M   $��DANH SÁCH SẢN PHẨM��6[   $��Center=�6u   � 5@       5A      �� 5B   "   $��6* �63   �� 5C   "   $
��auto �63   �� 5D   "   $��3* �63   .+�5G        -   5        $��
SearchZone��5G   c   $ Standard=�67   $��0��6G   $	��400��6W   $��8 4 8 4q�5H   ,      CornerRadius$ 2��5I   ,    K� ZIndex$ 1��5J   ,   $��16 0 0 0q�5K   ,   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5L   ,   .��5M   "   �  5N   &   �� 5O   *   $
��Auto �6;   �� 5P   *   $��* �6;   �� 5Q   *   $
��Auto �6;   .+�5S   &   �� -   5        $��SearchButton��5S   -     MaterialDesignToolButton#���  6\   .��5T   *   '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Magnify=�6B   
 J� Opacity$	
 .56Q�6Q   5U   '   �� 5V   &   -   5        $��SearchTextBox��5]   #   $��1��5V   .   $��8 0 0 0q�5W   #   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$) #Nhập tên sản phầm cần tìm��5X   #   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5Y   #   $��0q�5Z   #   $	��200��5[   #   $��Center=�5\   #   5_   #   5`   #   5a      �� 5c      -   5        $��ProductAddButton��5c   5   $��1��6%   
���/���.��5d   "     $
	 Plus=�6:   $��30��6F   $��30��6R   $��Center=�6]   
���   �6x   5e      �� 5g      -   5        $��PageNavigationPanel��5h   )   $ 
Horizontal=�5g   )   $��2��6B   $��Center=�6R   .+�5i   "   �� -   5        $��PreviousPageButton��5j   )   $��Right=�5i   )    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5l   )   .��5m   &     $	 NavigateBefore=�6>   $
��auto��6T   $
��auto��6b   5n   #   �� 5o   "   -	   5        $��CurrentPageTextBox��5o   *    � Cursor$
 Hand��5t   *   $��60��5u   *   $��0q�5v   *    �� TextAlignment$ Center=�5w   *   $��Center=�5x   *   $��20(�5y   *   $��5 0 5 0q�5z   *    �� SelectionBrush
 �   ����	#FF673AB7���	#DDFFFFFF6i   �� 5{   "   -
   5        $��NextPageButton��5|   )   $��Right=�5{   )   #��[ 5~   )   .��5   2     $	 NavigateNext=�6J   $
��auto��6^   $
��auto��6l   5�   #   5�      5�      5�      5�      �� 5�      -   5        $��NotExistTextblock��5�   @   $+��%Không tìm thấy sản phẩm nào!��6   $y�	Collapsed=�6Y   $��
Bree Serif)�5�   3   $��30(�6K   $��Center=�6Y   $��0 30 0 0q�6v   �� 5�      -   5        $��NothingToShowTextblock��5�      $��
Bree Serif)�5�      $��30(�60   $��Center=�6>   $��0 30 0 0q�6[   $6��0Không có sản phẩm nào để hiển thị!��5�      $y�	Collapsed=�5�      �� 5�      -   5        $��ProductListview��5�      ��.  $��20q�6X   $��Disabled=�5�      $��Center=�5�      ��5�      �� 5�      .R�5�      � 5�      ��5�      �� 5�      .R�5�      �� $��1q�6%    �� CornerRadius$ 10��69    �� Padding$ 10q�6K   
�������$	��210��6p   $	��340��6|   ._�5�   "   ]� .+�5�   &   �� $	��Top=�61   .+�5�   *   � .+�5�   .   A� $	��180��66   $	��180��6C   ��5�   2   �� 5�   6    �� Color$
 Gray��6F    J� Effect 5�   2   3	  -System.Windows.Media.Effects.DropShadowEffect	  5�   6    	  ShadowDepth$ 1Q�6G    	  
BlurRadius$ 5Q�6W   ��5�   2   �� 5�   6    j� Stretch$ UniformToFill=�6�    �� ImageSource 6A   �� *avt+ �� 	Converter# [  6�   5�   /   A� 5�   .   $	��180��66   $	��180��6C   ��5�   2   �� 5�   6   $
 Gray��6F    5�   2   	  5�   6   $ 1Q�6G   $ 5Q�6W   ��5�   2   �� 5�   6   $ UniformToFill=�6�    6A   �� *
nhapthem+# [ 6�   5�   /   5�   +   �� 5�   *   $
��Wrap=�6I   $��
Bree Serif)�6]   $��Center=�6u   
���  ��$��15(�6�   $��10q�6�   $��Center=�6�   ��64   �� *ten+6�   5�   '   � 5�   &   $��Bottom=�6+   $��Bottom=�6C   .+�5�   *   �� $��Bottom=�65   $��Bottom=�6M   $
��Left=�6h   .+�5�   .   �� $ 
Horizontal=�69   .+�5�   2   �� $��Đã bán: ��6<   �� 5�   2   ��6<   �� *daban+5�   /   �� 5�   .   $ 
Horizontal=�69   .+�5�   2   �� $��Tồn kho: ��6<   �� 5�   2   ��6<   �� *tonkho+5�   /   5�   +   '
  !MaterialDesignThemes.Wpf.PopupBox
  5�   *   $��Bottom=�6B   $��Bottom=�6Z   $��Right=�6u   $��2 0 2 0q�6�    
  PopupContent. 5�   .   �� .+�5�   2   �� $��ProductUpdateButton��69   -   5        $��Cập nhật sản phẩm��5�   T   $��Center=�6r   6�   �� 5�   2   $��ProductDeleteButton��69   -   5        $��Xóa sản phẩm��5�   T   $��Center=�6l   6�   5�   /   5�   +   5�   '   �� 5�   &   $��Bottom=�6-   $��2q�6E   $ 3q�6Y   $ 5��6e   
��� � �$��Center=�6�   $��Bottom=�6�   $��5q�6�   ._�5�   *   �� $��12(�64   $
��Bold"�6B   
��� � �$��Center=�6�   ��6g   �� *giaban+# [ 6�   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      