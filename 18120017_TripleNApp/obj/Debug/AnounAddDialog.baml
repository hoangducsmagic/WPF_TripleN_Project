   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   )    #_18120017_TripleNApp.AnounAddDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:_18120017_TripleNApp     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$$  Thêm thông báo nhập hàng��5   	   ���#ffffb5 � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�6H   $	��250��5   	   $	��400��6   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6      CaptionHeight$ 0Q�61    J� Clip 5      �� 5   
    �� RadiusX$ 25Q�6   	 �� RadiusY$	 25Q�6)   
 �� Rect$
 0,0,400,250�66   .��5      �� .+�5   
   � -   5        $��TitleBar��5      
���   �$	��Top=�62   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5      �� $��ImagesResource/icon.png��6   $��0 0 20 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   �� 5      $%��Thêm  thông báo nhập hàng��6   $��	Amatic SC)�6=   $
��Bold"�6T   $��20 pt(�6f   
������$��Center=�6�   $��Center=�6�   �� 5      $��ImagesResource/icon.png��6   $��20 0 0 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   5      5      �� 5   
   $
��Auto=�6   .��5       �� $��10q�6   .+�5!      �� $ 
Horizontal=�6   $��10q�66   .+�5"      �� $��Ngày thông báo: ��6    $��Center=�68   (  "System.Windows.Controls.DatePicker  5#      -   5        $��
DatePicker��5%      
���  ��$��Bottom=�5#   7   $��	0 -16 0 0q�6R   
 �� Now   SelectedDate# Z 5$      $	��160��6E   $��35��6Q   $��Center=�6]    (  $MaterialDesignFloatingHintDatePicker#��[  5'      5(      �� 5)      $ 
Horizontal=�6   $��10q�66   .+�5*      �� $��Nội dung thông báo: ��6    �� 5+      -   5        $��AnounTextbox��5+   U    ! MaterialDesignOutlinedTextBox#��[ 6   $��10 0 0 0q�5,   &   $	��Top=�5-   &   $��70��5.   &   $	��200��5/   &    �� AcceptsReturn .   �� TextWrapping$
 Wrap=�51   &   " �� VerticalScrollBarVisibility$
 Auto=�52   &   54      �� 56      $ 
Horizontal=�6   $��Center=�66   .+�57      �� -   5        $��AnounAddButton��57   5   $��Tạo thông báo��6   $��10q�6h   �� 58      -   5        $��
BackButton��58   0   $��
Quay lại��6   $��10q�6\   59      5:      5;      5<      5>      