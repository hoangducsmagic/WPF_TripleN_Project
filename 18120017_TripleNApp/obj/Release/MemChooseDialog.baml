   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  *    $_18120017_TripleNApp.MemChooseDialog   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  ���#ffffb5  � WindowStartupLocation$  CenterScreen=� � AllowsTransparency .  � WindowStyle$
 None=� � Title$ MemChoseDialog��$	��400��$	��650��'  !System.Windows.Shell.WindowChrome   WindowChrome      ResizeBorderThickness$ 0q�   CaptionHeight$ 0Q� J� Clip ��  �� RadiusX$ 25Q�	 �� RadiusY$	 25Q�
 �� Rect$
 0,0,650,400�.���� .+�� -   $��TitleBar��
���   �$	��Top=�.+���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� $��ImagesResource/icon.png��$��0 0 20 0q�$��40��$��40��$��Center=�$��Center=��� $��Chọn khách hàng��$��	Amatic SC)�$
��Bold"�$��20 pt(�
������$��Center=�$��Center=��� $��ImagesResource/icon.png��$��20 0 0 0q�$��40��$��40��$��Center=�$��Center=��� $
��Auto=�.���� .+��� $!��DANH SÁCH KHÁCH HÀNG CŨ��$��
Bree Serif)�$��25(�
���  ��$��20q�$��Center=�� .+��� -   $��MemListview��$��Center=�$	��200��$
��Auto=����� .R��� ���� .R��� .+��� 
����+���� $ 
Horizontal=�.+��� $��Tên: ��$
��Bold"�$��5q��� $��5q����� *ten+�� $��   -   SĐT: ��$
��Bold"�$��5q��� $��5q����� *sdt+�� -   $��EmptyTextblock��
�������$2��,(Bạn chưa có khách hàng cũ nào cả)��$y�	Collapsed=�$��Italic$�$��13(�$��Center=��� $��Center=�$ 
Horizontal=�$��20q�.+��� -   $��OKButton��$��Chọn��$��10q��� -   $��
BackButton��$��
Quay lại��$��10q�