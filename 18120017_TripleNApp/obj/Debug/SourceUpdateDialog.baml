   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5   	   -    '_18120017_TripleNApp.SourceUpdateDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:_18120017_TripleNApp     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ���#ffffb5  � WindowStartupLocation$  CenterScreen=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�6H    � Title$ SourceUpdateDialog��5   	   $	��360��6$   $	��800��61   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61    J� Clip 5      �� 5   
    �� RadiusX$ 25Q�6   	 �� RadiusY$	 25Q�6)   
 �� Rect$
 0,0,800,360�66   .��5      �� .+�5   
   � -   5        $��TitleBar��5      
���   �$	��Top=�62   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5      �� $��ImagesResource/icon.png��6   $��0 0 20 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   �� 5      $,��&CẬP NHẬT THÔNG TIN NGUỒN NHẬP��6   $��	Amatic SC)�6A   $
��Bold"�6X   $��20 pt(�6j   
������$��Center=�6�   $��Center=�6�   �� 5      $��ImagesResource/icon.png��6   $��20 0 0 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   5      5      �� 5   
   $
��Auto=�6   .��5!      �� $��10q�6   .+�5"      �� $ 
Horizontal=�6   $��0 0 0 10q�66   .+�5#      �� $��Mã sản phẩm: ��6    $��
Bree Serif)�65   
�������$��20(�6_   $��
10 10 0 10q�6n   �� 5$      -   5        $��SourceIDTextbox��5$   !   $��
Bree Serif)�69   
�������$��20(�6c   $��
0 10 10 10q�6r   5%      �� 5&      -   5        $��SourceNameTextbox��5&   P   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên nguồn nhập hàng��6   $��
Bree Serif)�6i   
���  ��$��20(�6�   $
��Bold"�6�      MaterialDesignTextBox#��[  5'      $��10q�6M   �� 5(      -   5        $��SourceLinkTextbox��5(   P   $ Link nguồn nhập hàng��6   $��
Bree Serif)�6i   
���  ��$��20(�6�   $
��Bold"�6�   #��[  5)      $��10q�6M   �� 5*      -   5        $��SourceAddressTextbox��5*   Q    ! MaterialDesignOutlinedTextBox#��[ 6   $��10q�5,      $	��Top=�5-      $��70��5.       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�50      " �� VerticalScrollBarVisibility$
 Auto=�51      $' !Địa chỉ nguồn nhập hàng��52      �� 54      $ 
Horizontal=�6   $��Center=�66   .+�55      �� -   5        $��SourceUpdateButton��55   0   $��Cập nhật��6   $��10q�6k   �� 56      -   5        $��
BackButton��56   0   $��
Quay lại��6   $��10q�6[   57      58      5:      5;      5>      