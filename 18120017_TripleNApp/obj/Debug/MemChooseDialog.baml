   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5   	   *    $_18120017_TripleNApp.MemChooseDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:_18120017_TripleNApp     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ���#ffffb5  � WindowStartupLocation$  CenterScreen=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�6H    � Title$ MemChoseDialog��5   	   $	��400��6    $	��650��6-   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61    J� Clip 5      �� 5   
    �� RadiusX$ 25Q�6   	 �� RadiusY$	 25Q�6)   
 �� Rect$
 0,0,650,400�66   .��5      �� .+�5   
   � -   5        $��TitleBar��5      
���   �$	��Top=�62   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5      �� $��ImagesResource/icon.png��6   $��0 0 20 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   �� 5      $��Chọn khách hàng��6   $��	Amatic SC)�63   $
��Bold"�6J   $��20 pt(�6\   
������$��Center=�6�   $��Center=�6�   �� 5      $��ImagesResource/icon.png��6   $��20 0 0 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   5      5      �� 5   
   $
��Auto=�6   .��5      �� .+�5      �� $!��DANH SÁCH KHÁCH HÀNG CŨ��6    $��
Bree Serif)�6?   $��25(�6W   
���  ��$��20q�6z   $��Center=�6�   � 5       .+�5!      �� -   5        $��MemListview��5!   #   $��Center=�66   $	��200��6S   $
��Auto=�6`   ��5"      �� 5#   "   .R�5$   &   �� 5%   #   ��5'      �� 5(   "   .R�5)   &   �� .+�5*   *   �� 
����+��64   �� 5+   *   $ 
Horizontal=�65   .+�5,   .   �� $��Tên: ��68   $
��Bold"�6E   $��5q�6W   �� 5-   .   $��5q�6M   ��68   �� *ten+6M   �� 5.   .   $��   -   SĐT: ��68   $
��Bold"�6L   $��5q�6^   �� 5/   .   $��5q�6M   ��68   �� *sdt+6M   50   +   51   '   52   #   54      �� 55      -   5        $��EmptyTextblock��55   $   
�������$2��,(Bạn chưa có khách hàng cũ nào cả)��6Q   $y�	Collapsed=�6{   $��Italic$�6�   $��13(�6�   $��Center=�6�   56      �� 58      $��Center=�6!   $ 
Horizontal=�6>   $��20q�6W   .+�59      �� -   5        $��OKButton��59   0   $��Chọn��6!   $��10q�6@   6M   �� 5:      -   5        $��
BackButton��5:   4   $��
Quay lại��6!   $��10q�6F   6R   5;      5<      5>      5?      5C      