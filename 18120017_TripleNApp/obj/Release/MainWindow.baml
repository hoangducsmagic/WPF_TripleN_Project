   M S B A M L   `   `   `  ���� N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  %    _18120017_TripleNApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:_18120017_TripleNApp     b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � WindowStartupLocation$  CenterScreen=� � AllowsTransparency .  � WindowStyle$
 None=� � Title$ 
MainWindow��$	��700��$
��1245�� � Icon ��  �� 	UriSource$ ImagesResource/icon.png?� �� BitmapScalingMode$ HighQuality=�'  !System.Windows.Shell.WindowChrome   WindowChrome      ResizeBorderThickness$ 0q�	   CaptionHeight$	 0Q�
 J� Clip
 ��  �� RadiusX$ 25Q� �� RadiusY$ 25Q� �� Rect$ 0,0,1245,700� � 	Resources    OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%6  &	        &	     �� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ StackPanelMenu��.\�  $ 0��$ 0Q�  $ 0:0:0.5��$	 250Q�U� $ (UIElement.Opacity)�$ 	MainFrame��.\�  $ 0��$ 1Q�  $ 0:0:0.5��$	 0.3Q��� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ StackPanelMenu��.\�  $ 0��$	 250Q�  $ 0:0:0.5��$ 0Q�U� $ (UIElement.Opacity)�$ 	MainFrame��.\�  $ 0��$	 0.3Q�  $ 0:0:0.5��$ 1Q� � Triggers :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ ButtonOpenMenu��.[��� #��[  :� $ ButtonBase.Click��$ ButtonCloseMenu��.[��� -    ��Name$ CloseMenu_BeginStoryboard��#��[ :� $! UIElement.MouseLeftButtonUp��$ ProductButton��.[��� -   $# ProductButton_BeginStoryboard��#��[ :� $! UIElement.MouseLeftButtonUp��$ 
BillButton��.[��� -   $  BillButton_BeginStoryboard��#��[ :� $! UIElement.MouseLeftButtonUp��$ ImportButton��.[��� -   $" ImportButton_BeginStoryboard��#��[ :� $! UIElement.MouseLeftButtonUp��$ StatisticButton��.[��� -   $% StatisticButton_BeginStoryboard��#��[ :� $! UIElement.MouseLeftButtonUp��$ SettingButton��.[��� -   $# SettingButton_BeginStoryboard��#��[ .��� .+��� -   $��StackPanelMenu��$��-250 50 0 0q�$
��Left=�$	��250�� J� RenderTransformOrigin$ 0.5,0.5&����#96d979 K� ZIndex$ 1��z�V� .~��� �� �� T� .+��� $��ImagesResource/icon.png��$	��150��$	��150��$��Center=�$ HighQuality=�$��20 40 20 40q�� .+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -	     Name$ TrainsitionigContentSlide��C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��� -
    �Name$ 
GridCursor�����	#FF0069C0$��10��$
��Left=�$��60��$	��Top=��� -   $��MenuListview��.@��� -   $��ProductButton��$��60��.����  �� Orientation$ 
Horizontal=�$
��10 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Cake=�$��30��$��30��$��Center=�$��5q��� $��Sản phẩm��$��10q�$��Center=��� -   $��
BillButton��$��60��.���� $ 
Horizontal=�$
��10 0q�.+�  $ Payment=�$��30��$��30��$��Center=�$��5q��� $��
Hóa đơn��$��10q�$��Center=��� -   $��ImportButton��$��60��.���� $ 
Horizontal=�$
��10 0q�.+�  $ ChartArc=�$��30��$��30��$��Center=�$��5q��� $��Nguồn nhập��$��10q�$��Center=��� -   $��StatisticButton��$��60��.���� $ 
Horizontal=�$
��10 0q�.+�  $ 
InfoCircle=�$��30��$��30��$��Center=�$��5q��� $��Thống kê��$��10q�$��Center=��� -   $��SettingButton��$��60��.���� $ 
Horizontal=�$
��10 0q�.+�  $ Settings=�$��30��$��30��$��Center=�$��5q��� $��Cài đặt��$��10q�$��Center=�� -   $��TitleBar��
���   �$	��Top=�.+��� -    ��Name$ ButtonCloseMenu�� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ $��30��$��30��$��0q�$��Center=�$
��Left=�$��10q�$y�	Collapsed=���Z� ��Z� .��  $
 Menu=�
�������� -   $ ButtonOpenMenu��#��[ $��30��$��30��$��0q�$	��Top=�$
��Left=�$��10q���Z� ��Z� .��  $
 Menu=�
�������� $ 
Horizontal=�$��Center=�$��Center=�.+��� $��ImagesResource/icon.png��$��0 0 20 0q�$��40��$��40��$��Center=�$��Center=��� $$��TRIPLEN ONLINE SHOP MANAGEMENT��$��	Amatic SC)�$
��Bold"�$��20 pt(�
������$��Center=�$��Center=��� $��ImagesResource/icon.png��$��20 0 0 0q�$��40��$��40��$��Center=�$��Center=��� $ 
Horizontal=�$��Center=�$��Right=�$��RightToLeft=�$��10q�.+��� -   $ ButtonClose��$��30��$��30��$��0q���Z� ��Z� .��  $ Power=�
�������� -   $��ButtonMinimize��$��30��$��30��$��0q���Z� ��Z� .��  $ WindowMinimize=�
�������� -   $��
ButtonInfo��$��30��$��30��$��0q���Z� ��Z� .��  $ InfoCircleOutline=�
������ � -   $��	MainFrame��   � NavigationUIVisibility$  Hidden=�$��0 50 0 0q�