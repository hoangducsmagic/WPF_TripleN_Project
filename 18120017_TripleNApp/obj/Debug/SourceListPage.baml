   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5      )    #_18120017_TripleNApp.SourceListPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:_18120017_TripleNApp     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#ddffcf N� Title$ SourceListPage��5       � 	Resources 5      )   #_18120017_TripleNApp.MoneyConverter   MoneyConverter,   &_18120017_TripleNApp.FavoriteConverter  FavoriteConverter��%:   &	        &	        5   
   6     5   
   6"   5      .��5      �� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��16q�65   .��5      �� .+�5      �� $��	Amatic SC)�6   $
��Bold"�63   $��40(�6E   $%��DANH SÁCH NGUỒN NHẬP HÀNG��6S   $��Center=�6t   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5        -   5        $��
SearchZone��5   /   $ Standard=�6A   $	��400��6Q   $��8 4 8 4q�5   ,      CornerRadius$ 2��5   ,    K� ZIndex$ 1��5   ,   $��16 0 0 0q�5   ,   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5   ,   .��5      �  � ColumnDefinitions 5      �� 5   "   $
��Auto �63   �� 5    "   $��* �63   �� 5!   "   $
��Auto �63   .+�5#      �� -   5        $��SearchButton��5#   %     MaterialDesignToolButton#���  6T   .��5$   "   '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Magnify=�6:   
 J� Opacity$	
 .56Q�6I   5%      �� 5&      -   5        $��SearchTextBox��5-   #   $��1��5&   &   $��8 0 0 0q�5'   #   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$* $Nhập tên nguồn hàng cần tìm��5(   #   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5)   #   $��0q�5*   #   $	��200��5+   #   $��Center=�5,   #   5/   #   50      51      �� 53      -   5        $��SourceAddButton��53   /   $��30 0 0 0q�6   
���/���.��54        $
	 Plus=�62   $��30��6>   $��30��6J   $��Center=�6U   
���   �6p   55      56      57      58      �� 59   
   -   5        $��NothingToShowTextblock��59      $��Center=�62   $��0 30 0 0q�6O   $��
Bree Serif)�5:      $��30(�60   $>��8Không có nguồn nhập hàng nào để hiển thị!��5;      $y�	Collapsed=�5<      �� 5=   
   -   5        $��NotExistTextblock��5=   ;   $.��(Không tìm thấy nguồn nhập hàng!��6   $y�	Collapsed=�6T   �� 5>   
   -   5        $��ContentPanel��5>      .+�5?      � $
��1045��6   $��Center=�6    $��0 40 0 0q�6=    5@      �� 5A      $��* �6'   �� 5B      $��* �6'   �� 5C      $��* �6'   �� 5D      $��* �6'   �� 5E      $��* �6'   .+�5G      �� $��0��6   $��Mã nguồn nhập��6,   $��20(�6A   $��Center=�6O   $
��Bold"�6l   �� 5H      $��1��6   $��Tên nguồn nhập��6,   $��20(�6B   $��Center=�6P   $
��Bold"�6m   �� 5I      $��2��6   $��Tổng tiền nhập��6,   $��20(�6C   $��Center=�6Q   $
��Bold"�6n   �� 5J      $��3��6   $��Yêu thích��6,   $��20(�6=   $��Center=�6K   $
��Bold"�6h   5K      �� 5L      -   5        $��SourceListview��5L      $��Center=�6-   $
��Auto=�6J   ��.  ��5N      �� 5O      .R�5P      �� 5Q      ��5S      �� 5T      .R�5U      �� .+�5V      �� $��1q�6(   
�������6<   � 5W      $
��1045��6#   $��Center=�60    5X   "   �� 5Y   &   $��* �67   �� 5Z   &   $��* �67   �� 5[   &   $��* �67   �� 5\   &   $��* �67   �� 5]   &   $��* �67   .+�5_   "   �� $��0��6,   $��Center=�6Q   $��Center=�6n   ��6<   �� *ma+6n   �� 5`   "   $��1��6,   $��Center=�6R   $��Center=�6o   ��6<   �� *ten+6o   �� 5a   "   $��2��6,   $��Center=�6�   $��Center=�6�   ��6<   �� *
tongtien+ �� 	Converter# [  6�   �� 5b   "   -	   5        $��3��5b   )    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5c   )   $��Center=�5d   )   .��5g   &     $	 Heart=�6>   ��6L   �� *
yeuthich+# [ 5h   #   �� 5i   "   $��SourceDeleteButton��6�   -
   5        $��4��5i   )   $
��Xóa��69   $��Center=�6G   $��Center=�6e   6�   5j      5k      5l      5n      5o      5p      5q      