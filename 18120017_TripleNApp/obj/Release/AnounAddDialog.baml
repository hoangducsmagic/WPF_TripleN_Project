   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem )    #_18120017_TripleNApp.AnounAddDialog   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:_18120017_TripleNApp     6sys&clr-namespace:System;assembly=mscorlib     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$$  Thêm thông báo nhập hàng�����#ffffb5 � WindowStartupLocation$ CenterScreen=� � AllowsTransparency .  � WindowStyle$
 None=�$	��250��$	��400��'  !System.Windows.Shell.WindowChrome   WindowChrome      ResizeBorderThickness$ 0q�   CaptionHeight$ 0Q� J� Clip ��  �� RadiusX$ 25Q�	 �� RadiusY$	 25Q�
 �� Rect$
 0,0,400,250�.���� .+�� -   $��TitleBar��
���   �$	��Top=�.+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� $��ImagesResource/icon.png��$��0 0 20 0q�$��40��$��40��$��Center=�$��Center=��� $%��Thêm  thông báo nhập hàng��$��	Amatic SC)�$
��Bold"�$��20 pt(�
������$��Center=�$��Center=��� $��ImagesResource/icon.png��$��20 0 0 0q�$��40��$��40��$��Center=�$��Center=��� $
��Auto=�.���� $��10q�.+��� $ 
Horizontal=�$��10q�.+��� $��Ngày thông báo: ��$��Center=�(  "System.Windows.Controls.DatePicker  -   $��
DatePicker��
���  ��$��Bottom=�$��	0 -16 0 0q�
 �� Now   SelectedDate# Z $	��160��$��35��$��Center=� (  $MaterialDesignFloatingHintDatePicker#��[  �� $ 
Horizontal=�$��10q�.+��� $��Nội dung thông báo: ���� -   $��AnounTextbox�� ! MaterialDesignOutlinedTextBox#��[ $��10 0 0 0q�$	��Top=�$��70��$	��200�� �� AcceptsReturn .   �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=��� $ 
Horizontal=�$��Center=�.+��� -   $��AnounAddButton��$��Tạo thông báo��$��10q��� -   $��
BackButton��$��
Quay lại��$��10q�