   M S B A M L   `   `   `  ����D  @DailyNews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DailyNews	DailyNews  5   	   ;"clr-namespace:DailyNews.ConvertersDailyNews.Converters  5   	   C&clr-namespace:DailyNews.VideoElementNSDailyNews.VideoElementNS  5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5	   	   .    (DailyNews.Views.frmAddUpdatesSocialMedia   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %bclr-namespace:DailyNews     5   	   9
Converters"clr-namespace:DailyNews.Converters     5   	   ?VideoElement&clr-namespace:DailyNews.VideoElementNS     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5	   	   -   5          � Title$  frmAddEditNews��5   	   $
��1000��6!   $	��850��6/    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q    � WindowStyle$
 None=�6v    � 	Resources 5      3  -DailyNews.Converters.ConvertToEeasternNumbers   ConvertToEeasternNumbers.  (DailyNews.Converters.ConverterToBitImage  ConverterToBitImage   DailyNews.ImageButton �� 
TargetType �� Property �� Value �� RelativeSource	 �� 
TargetType
 ��Name �� Path  TextBoxLable �� CornerRadius �� Color J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   ShadowDepth �� TextAlignment �� Padding  MaterialDesignComboBox �� BasedOn��%y  &	        &	      '  &     &	 9    '��     '�� s    7    5   
   6.     5   
   6)   �� 5   
   "  6/   .�5      ��  � �� 6'   �� *width+ �� *TemplatedParent+�� 5       � �� 6&   �� *width+ �� *TemplatedParent+�� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$	 7 3q�6'   �� 5       � �� 5      �� 5      "	  6&   .R�5      �� ._�5      �� $
 _Image��6$   $��Center=�64   $��Center=�6Q   #��z��6l   #��z��5   m   ��6   �� $ Source� �� *TemplatedParent+6m   5      5      5      5      �� 5   
   " ��6%   .�5       ��  � ��$ 21(�6)   �� 5!       � ��
 �   �6+   �� 5"       � ��$ 	10 2 10 2q�6'   �� 5#       �@��TextWrapping$
 Wrap=�6-   �� 5$       �@��TextAlignment$ Center=�6.   �� 5%       � ��$ 5q�6(   �� 5&       � ��
 �  ��6+   �� 5'       � �� 5(      �� 5)      .R�5*      �� $ 5��6!   ��5+      �� 5,   "   $ DarkRed��62    5.        5/   "   $ 5Q�63   $ 1Q�6B   ._�51      �� 
�������$ Center=�6�   $��Center=�6�   ��6(   ��  �� *TemplatedParent+$
 Text� 6�   ��  �� *TemplatedParent+$ Padding�6�   52      53      55      56      �� 57   
   " ��6   .�58      ��  � ��$ 21(�6)   �� 59       � ��
 ��  �6+   5:      �� 5;   
   8   " ��6B   .�5<      ��  � ��
 ��  �6+   �� 5=       � ��$ 21(�6)   �� 5>       �@�Cursor$
 Hand��6'   �� 5?       � ��$
 10 0q�6'   5@      5A      .��5B      � $��RightToLeft=�6    � RowDefinitions 5C   
   �� 5D      $
��auto �6   �� 5E      �� 5F      $
��auto �6   .+�5H   
   � -   5         �Name$ TitleBar��5H      $��30��6"   $	��Top=�6/   
���  ��.+�5I      �� -   5         ��Name$ btnClose��5I       � Cursor$
 Hand��6(     TitleBarButtons#��[ 6M   $��Right=�6w   .��5J      �� $#��/Resource/close-window-48.png��6   5K      5L      �� 5M   
   $��1��6   $	��0 5q�6$   .��5N      �  � ColumnDefinitions 5O      �� 5P      $	��170 �6'   �� 5Q       5S      �� 5T      $
��auto �6$   $��55��62   �� 5U      $
��auto �6$   $��55��62   �� 5V      $
��auto �6$   $��55��62   �� 5W      $
��auto �6$   $��55��62   �� 5X      $
��auto �6$   $��55��62   �� 5Y      $
��auto �6$   $��55��62   .+�5[      �� -   5         ��Name$ tbkTitle��5[      $��العنوان ��6,   $��0��6<   $��0��6L   #��[ 6Y   $	��0 5q�6   �� 5\      -   5        $ txtTitle��5\       �� TextWrapping$
 Wrap=�6C   $��1��6W   $��0��6g   $	��0 5q�6t   $��Center=�6�   ��6,   �� *Title+6�   �� 5^      -   5        $ tbkObservers��5^      $��الراصد ��60   $��0��6?   $��1��6O   #��[ 6\   $	��0 5q�6�   �� 5_      -   5         ��Name$ cbxObservers��5_      $��1��6K   $��1��6[   $	��0 5q�6h   $��Center=�6u    �� Text 61   �� *
Observer+6u   �� 5a      -   5        $ Region��5a      $��الاقليم ��6*   $��0��6:   $��2��6J   #��[ 6W   $	��0 5q�6~   �� 5b      -	   5        $ 	cbxRegion��5b      $��1��6F   $��2��6V   $	��0 5q�6c   $��Center=�6p    6.   �� *Region+.@�5c      �� .��6#   
دولي6)   �� 5d      .��6#   
محلي6)   5e      �� 5g      -
   5        $ tbkDatePicker��5g      $
 Wrap=�61   $��التاريخ��6E   $��0��6T   $��3��6d   #��[ 6q   $	��0 5q�6�   &   Xceed.Wpf.Toolkit.DateTimePicker  5h      -   5          Name$ dtpDatePicker��5h   )   $��1��6A   $��3��6Q   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�6^      FormatString$ yyyy/MM/dd hh:mm tt��6n   $��16(�6�   $	��190��6�   $	��0 5q�6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]    Value  6�   �� *DateAndTime+6�   �� 5k      -   5        $ tbkImage��5k      $�� الصورة ��6,   $��0��6<   $��4��6L   #��[ 6[   $	��0 5q�6�   �� 5m      $��4��6   $��1��6*   .+�5n      �� -   5        ! ��Name$! Images��5n   #   ��5o      �� 5p      .R�5q      �� " ��Name$" 	ImageShow��6%   $ 5��68   $	��200��6I   $	��300��6V   $��LeftToRight=�6e   $	��0 5q�6�   ��5r   "   �� 5s   *   # �� ImageSource# 65   �� ._�5u   &   �� $
 DeleteImage��6,   -   5        $��/Icons/DeleteIcon.png��5u   A   $��20��6`   $��20��6k   $	��Top=�6w   $
��Left=�6�   $��5q�6�   $
 Hand��6�   6�   5v   #   5w      ��5y      �� 5z      .R�5{      �� $ �� Orientation$$ Vertical=�6)   5|      5~      �� 5      -   5        $" AddImage��5      $��35��6/   $��35��6;   $ 10��6F   $
 Hand��6X   $��Center=�6f   % � ToolTip$$% أنقر لإضافة صورة��6�   ��5�      �� 5�      " ��6$   .�5�   "   ��  � �� 5�   &   �� 5�   *   $# /Icons/AddIcon.png��65   5�   #   5�      5�      5�      �� 5�      -   5        $ 
tbkComment��5�      $��التعليق��6.   $��0��6=   $��5��6M   #��[ 6Z   $	��0 5q�6�   �� 5�      -   5        $ 
txtComment��5�      & �� AcceptsReturn& . $��1��6E   $��5��6U   $
 Wrap=�6|   $	��0 5q�6�   ��6c   �� *	Comment+6�   5�      5�      � 5�   
   $��2��6   $
��auto��6   
���  ��.+�5�      �� $$ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5�      �� -   5        $	��0 5q�5�      
���  ��.��5�      �� $$ 
Horizontal=�6   .+�5�      �� $��/Icons/OkIcon.png��6   $	��5 0q�67   �� 5�      $
��تم��6    5�      5�      �� 5�      $��منشورات سرية��6   $��10 0 0 0q�6N   
�������
�������$��14(�6�   ' d� 	IsChecked' 6/   �� *
IsHidden+6�   5�      5�      5�      5�      