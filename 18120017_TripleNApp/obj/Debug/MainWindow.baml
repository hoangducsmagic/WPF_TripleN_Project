   M S B A M L   `   `   `  ����N  J18120017_TripleNApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_18120017_TripleNApp_18120017_TripleNApp  5   	   %    _18120017_TripleNApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:_18120017_TripleNApp     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � WindowStartupLocation$  CenterScreen=�5
   	    � AllowsTransparency .  � WindowStyle$
 None=�6H    � Title$ 
MainWindow��5   	   $	��700��6   $
��1245��6)    � Icon 5      �� 5   
    �� 	UriSource$ ImagesResource/icon.png?�6    �� BitmapScalingMode$ HighQuality=�5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      ResizeBorderThickness$ 0q�6   	   CaptionHeight$	 0Q�61   
 J� Clip
 5      �� 5   
    �� RadiusX$ 25Q�6    �� RadiusY$ 25Q�6)    �� Rect$ 0,0,1245,700�66    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%b  &	        &	 �    �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ StackPanelMenu��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $	 250Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ 	MainFrame��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.5��6'   $	 0.3Q�69   5       5!      �� 5#   
   .��5%      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ StackPanelMenu��6�   .\�5&        $ 0��6'   $	 250Q�63     5'      $ 0:0:0.5��6'   $ 0Q�69   5(      U� 5)      $ (UIElement.Opacity)�6,   $ 	MainFrame��6\   .\�5*        $ 0��6'   $	 0.3Q�63     5+      $ 0:0:0.5��6'   $ 1Q�69   5,      5-      5.       � Triggers 50      :� 51   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�52      �� #��[  6   53      :� 54   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�55      �� -   5         ��Name$ CloseMenu_BeginStoryboard��55      #��[ 6A   56      :� 57   
   $! UIElement.MouseLeftButtonUp��6   $ ProductButton��6A   .[�58      �� -   5        $# ProductButton_BeginStoryboard��58      #��[ 6E   59      :� 5:   
   $! UIElement.MouseLeftButtonUp��6   $ 
BillButton��6A   .[�5;      �� -   5        $  BillButton_BeginStoryboard��5;      #��[ 6B   5<      :� 5=   
   $! UIElement.MouseLeftButtonUp��6   $ ImportButton��6A   .[�5>      �� -   5        $" ImportButton_BeginStoryboard��5>      #��[ 6D   5?      :� 5@   
   $! UIElement.MouseLeftButtonUp��6   $ StatisticButton��6A   .[�5A      �� -   5        $% StatisticButton_BeginStoryboard��5A      #��[ 6G   5B      :� 5C   
   $! UIElement.MouseLeftButtonUp��6   $ SettingButton��6A   .[�5D      �� -   5        $# SettingButton_BeginStoryboard��5D      #��[ 6E   5E      .��5H      � .+�5J   
   �� -   5        $��StackPanelMenu��5J      $��-250 50 0 0q�6+   $
��Left=�6@   $	��250��6[    J� RenderTransformOrigin$ 0.5,0.5&�6g   ���#96d979 K� ZIndex$ 1��6�   z�5K      V� 5L      .~�5M      �� �� 5N      �� 5O      T� 5P      5Q      .+�5S      �� $��ImagesResource/icon.png��6   $	��150��65   $	��150��6B   $��Center=�6N   $ HighQuality=�6k   $��20 40 20 40q�6�   � 5T      .+�5U      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -	   5          Name$ TrainsitionigContentSlide��5U   6   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Y   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5V      � -
   5         �Name$ 
GridCursor��5V      ���	#FF0069C0$��10��6G   $
��Left=�6R   $��60��6m   $	��Top=�6y   5W      �� 5X      -   5        $��MenuListview��5X      .@�5Y      �� -   5        $��ProductButton��5Y   /   $��60��6#   .��5Z      ��  �� Orientation$ 
Horizontal=�6%   $
��10 0q�6>   .+�5[      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Cake=�66   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   �� 5\      $��Sản phẩm��6(   $��10q�68   $��Center=�6D   6a   5]      5^      �� 5`      -   5        $��
BillButton��5`   /   $��60��6#   .��5a      �� $ 
Horizontal=�6%   $
��10 0q�6>   .+�5b        $ Payment=�66   $��30��6E   $��30��6P   $��Center=�6\   $��5q�6w   �� 5c      $��
Hóa đơn��6(   $��10q�67   $��Center=�6C   6`   5d      5e      �� 5g      -   5        $��ImportButton��5g   /   $��60��6#   .��5h      �� $ 
Horizontal=�6%   $
��10 0q�6>   .+�5i        $ ChartArc=�66   $��30��6F   $��30��6Q   $��Center=�6]   $��5q�6x   �� 5j      $��Nguồn nhập��6(   $��10q�6:   $��Center=�6F   6c   5k      5l      �� 5n      -   5        $��StatisticButton��5n   /   $��60��6#   .��5o      �� $ 
Horizontal=�6%   $
��10 0q�6>   .+�5p        $ 
InfoCircle=�66   $��30��6H   $��30��6S   $��Center=�6_   $��5q�6z   �� 5q      $��Thống kê��6(   $��10q�68   $��Center=�6D   6a   5r      5s      �� 5u      -   5        $��SettingButton��5u   /   $��60��6#   .��5v      �� $ 
Horizontal=�6%   $
��10 0q�6>   .+�5w        $ Settings=�66   $��30��6F   $��30��6Q   $��Center=�6]   $��5q�6x   �� 5x      $��Cài đặt��6(   $��10q�67   $��Center=�6C   6`   5y      5z      5{      5|      5~      � 5�   
   -   5        $��TitleBar��5�      
���   �$	��Top=�62   .+�5�      �� -   5         ��Name$ ButtonCloseMenu��5�       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6.   $��30��6t   $��30��6   $��0q�6�   $��Center=�6�   $
��Left=�6�   $��10q�6�   $y�	Collapsed=�6  ��6�   Z� ��6�   Z� .��5�        $
 Menu=�6*   
������66   5�      �� 5�      -   5        $ ButtonOpenMenu��5�      #��[ 6.   $��30��6t   $��30��6   $��0q�6�   $	��Top=�6�   $
��Left=�6�   $��10q�6�   ��6�   Z� ��6�   Z� .��5�        $
 Menu=�6*   
������66   5�      �� 5�      $ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5�      �� $��ImagesResource/icon.png��6   $��0 0 20 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   �� 5�      $$��TRIPLEN ONLINE SHOP MANAGEMENT��6   $��	Amatic SC)�6B   $
��Bold"�6Y   $��20 pt(�6k   
������$��Center=�6�   $��Center=�6�   �� 5�      $��ImagesResource/icon.png��6   $��20 0 0 0q�69   $��40��6K   $��40��6W   $��Center=�6b   $��Center=�6   5�      �� 5�      $ 
Horizontal=�6   $��Center=�62   $��Right=�6M   $��RightToLeft=�6i   $��10q�6�   .+�5�      �� -   5        $ ButtonClose��5�      $��30��6.   $��30��69   $��0q�6r   ��6E   Z� ��6[   Z� .��5�        $ Power=�6.   
������6;   5�      �� 5�      -   5        $��ButtonMinimize��5�      $��30��60   $��30��6;   $��0q�6t   ��6G   Z� ��6]   Z� .��5�        $ WindowMinimize=�6.   
������6D   5�      �� 5�      -   5        $��
ButtonInfo��5�      $��30��6,   $��30��67   $��0q�6p   ��6C   Z� ��6Y   Z� .��5�        $ InfoCircleOutline=�6.   
������6G   5�      5�      5�       � 5�   
   -   5        $��	MainFrame��5�         � NavigationUIVisibility$  Hidden=�6!   $��0 50 0 0q�6A   5�      5�      