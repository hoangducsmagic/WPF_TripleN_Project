   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5      '    !_18120017_TripleNApp.BillListPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:_18120017_TripleNApp     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#ddffcf N� Title$ BillListPage��5       � 	Resources 5      )   #_18120017_TripleNApp.MoneyConverter   MoneyConverter(   "_18120017_TripleNApp.DateConverter  DateConverter��%:   &	        &	        5   
   6     5   
   6   5      .��5      �� $
��Auto=�6   .��5   
   �� .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'   $��16q�69   .��5      �� .+�5      �� $��	Amatic SC)�6    $
��Bold"�67   $��40(�6I   $��DANH SÁCH HÓA ĐƠN��6W   $��Center=�6p   �� 5       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5        -   5        $��
SearchZone��5   3   $ Standard=�6E   $	��400��6U   $��8 4 8 4q�5   ,      CornerRadius$ 2��5   ,    K� ZIndex$ 1��5   ,   $��16 0 0 0q�5   ,   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5   ,   .��5      �  � ColumnDefinitions 5   "   �� 5    &   $
��Auto �67   �� 5!   &   $��* �67   �� 5"   &   $
��Auto �67   .+�5$   "   �� -   5        $��SearchButton��5$   )     MaterialDesignToolButton#���  6X   .��5%   &   '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Magnify=�6>   
 J� Opacity$	
 .56Q�6M   5&   #   �� 5'   "   -   5        $��SearchTextBox��5.   #   $��1��5'   *   $��8 0 0 0q�5(   #   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$) #Nhập tên khách hàng cần tìm��5)   #   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5*   #   $��0q�5+   #   $	��200��5,   #   $��Center=�5-   #   50   #   51      52      �� 54      -   5        $��BillAddButton��54   3   $��30 0 0 0q�6!   
���/���.��55        $
	 Plus=�66   $��30��6B   $��30��6N   $��Center=�6Y   
���   �6t   56      57      58      59      �� 5:      -   5        $��NothingToShowTextblock��5:      $��Center=�66   $��0 30 0 0q�6S   $��
Bree Serif)�5;      $��30(�60   $5��/Không có đơn hàng nào để hiển thị!��5<      $y�	Collapsed=�5=      �� 5>      -   5        $��NotExistTextblock��5>   8   $%��Không tìm thấy đơn hàng!��6   $y�	Collapsed=�6Q   $��
Bree Serif)�5?   +   $��30(�6C   $��Center=�6Q   $��0 30 0 0q�6n   �� 5B      -   5        $��ContentPanel��5B      .+�5C      � $
��1045��6   $��Center=�6$   $��0 40 0 0q�6A    5D      �� 5E      $��* �6+   �� 5F      $��* �6+   �� 5G      $��* �6+   �� 5H      $��* �6+   �� 5I      $��* �6+   .+�5K      �� $��0��6    $��
Hóa đơn��60   $��20(�6?   $��Center=�6M   $
��Bold"�6j   �� 5L      $��1��6    $��Khách hàng��60   $��20(�6B   $��Center=�6P   $
��Bold"�6m   �� 5M      $��2��6    $��Ngày lập��60   $��20(�6A   $��Center=�6O   $
��Bold"�6l   �� 5N      $��3��6    $��Thành tiền��60   $��20(�6B   $��Center=�6P   $
��Bold"�6m   5O      �� 5P      -   5        $��BillListview��5P      $��Center=�6/   $
��Auto=�6L   ��.  ��5R      �� 5S      .R�5T      �� 5U      ��5W      �� 5X      .R�5Y      �� .+�5Z   "   �� $��1q�6,   
�������6@   � 5[   "   $
��1045��6'   $��Center=�64    5\   &   �� 5]   *   $��* �6;   �� 5^   *   $��* �6;   �� 5_   *   $��* �6;   �� 5`   *   $��* �6;   �� 5a   *   $��* �6;   .+�5c   &   �� $��0��60   $��Center=�6U   $��Center=�6r   ��6@   �� *ma+6r   �� 5d   &   $��1��60   $��Center=�6`   $��Center=�6}   ��6@   �� *khachhang.ten+6}   �� 5e   &   $��2��60   $��Center=�6�   $��Center=�6�   ��6@   �� *	ngaylap+ �� 	Converter# [ 6�   �� 5f   &   $��3��60   $��Center=�6�   $��Center=�6�   ��6@   �� *	thanhtien+# [  6�   �� 5g   &   $��BillDeleteButton��6�   -	   5        $��4��5g   -   $
��Xóa��6=   $��Center=�6K   $��Center=�6i   6�   5h   #   5i      5j      5l      5m      5n      5o      5q      