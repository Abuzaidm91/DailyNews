   M S B A M L   `   `   `  ����D  @DailyNews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DailyNews.VideoElementNSDailyNews.VideoElementNS  5   	   1clr-namespace:DailyNews.ViewsDailyNews.Views  5   	   ;"clr-namespace:DailyNews.ConvertersDailyNews.Converters  5   	   K*clr-namespace:DailyNews.StarRatingsControlDailyNews.StarRatingsControl  5	   	   %clr-namespace:DailyNews	DailyNews  5
   	   !    DailyNews.Views.frmViewNews   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8video&clr-namespace:DailyNews.VideoElementNS     5   	   /localclr-namespace:DailyNews.Views     5   	   9
Converters"clr-namespace:DailyNews.Converters     5   	   =locall*clr-namespace:DailyNews.StarRatingsControl     5	   	   %bclr-namespace:DailyNews     5
   	   -   5          � Title$  frmViewNews��5   	    � WindowStyle$
 None=�6   $	��850��60    � WindowStartupLocation$ CenterScreen=�6<    � 
ResizeMode$ NoResize=�6a   $��RightToLeft=�6w   
������� � 	Resources 5      (  "DailyNews.Converters.ConvertToNull  5   
      KeyConvertToNullOrEmpty  6#   3  -DailyNews.Converters.ConvertToEeasternNumbers  5   
   ConvertToEeasternNumbers  6.   .  (DailyNews.Converters.ConverterToBitImage  5   
   ConverterToBitImage  6)   �� 5   
      DailyNews.ImageButton'         �� 
TargetType"  6/   .�5      ��  �� Property � �� �� Value$ 35��6'   �� 5       � ��$ 35��6&   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$	 7 3q�6'   �� 5       � �� 5      �� 5       �� 
TargetType"  6&   .R�5      �� ._�5      �� 	 ��Name$	 _Image��6$   $��Center=�64   $��Center=�6Q   #��z��6l   #��z��5   m   ��6   �� 
 �� Path$
 Source� �� RelativeSource �� *TemplatedParent+6m   5      5      5      5       �� 5!   
   " ��6   .�5"      ��  � ��$ 
ExtraBlack"�6+   �� 5#       � ��$ 14(�6*   �� 5$       � ��$ 
Cordia New)�6,   �� 5%       � ��$
 Wrap=�6.   �� 5&       �@��TextAlignment$ Justify=�6.   5'      .��5)      � $��RightToLeft=�6    � RowDefinitions 5*   
   �� 5+      $
��auto �6   �� 5,      �� 5-      $
��auto �6   .+�5/   
   � -   5         �Name$ TitleBar��5/      $��30��6"   $	��Top=�6/   ���	#FF673AB7.+�50      �� -   5         ��Name$ btnClose��50       � Cursor$
 Hand��6(     TitleBarButtons#��[ 6M   $��Right=�6w   .��51      �� $#��/Resource/close-window-48.png��6   52      53      �� 54   
   $��Visible=�6   $��1��6>   .��55      ]� ��.  .+�56      �� -   5         ��Name$ Title��56      $	��Top=�6+   $��Center=�6W    �� TextAlignment$ Center=�6t   $��30(�6�   $��	ExtraBold"�6�   $
��Wrap=�6�   ��6@   �� *Title+6�   �� 57      -   5        $ 	Resources��57      $	��Top=�6/   
���  ��$
��10 2q�6p   ��6E   �� *
Resource+6p   �� 58      -   5        $
 Date��58      $	��Top=�6*   $��LeftToRight=�6�   $ Right=�6�   
���  ��$
��10 2q�6�   ��6@   �� *DateAndTime+  ConvertToEeasternNumbers �� 	Converter# [ 6�   �� 59      -   5         ��Name$ Image��59      $	��Top=�6(    �� CornerRadius$ 5��6>   $	��280��6O   $	��450��6\   $��LeftToRight=�6h   $	��0 5q�6�   ��5:      �� 5;      " ��6     �� Triggers 5<      �� 5=   "    �� Binding 6.   �� *Image+  ConvertToNullOrEmpty# [  �� Value True6z   .a�5>   &   ��  � y�$ 	Collapsed=�6C   5?   #   5A      ��5C      �� 5D       �� ImageSource 6%   �� *Image+  ConverterToBitImage# [ 5F      �� 5G       �� Orientation$ 
Horizontal=�6   $	��Top=�66   $
��10 2q�6K   .+�5H      �� -   5        $ Auther��5H       $	��5 0q�6I   
����� �$��18(�6o   ��61   �� *Author+6o   1   +DailyNews.StarRatingsControl.RatingsControl  5I      -	   5          Name$ ratings1��5I   ,   1   +DailyNews.StarRatingsControl.RatingsControl   	MouseDown$ ratings1_MouseDown��5P   j      NumberOfStars$ 5��5K   1   $
��Left=�5L   1      StarOutlineColor$ DarkGray��5M   1      StarForegroundColor$ Orange��5N   1      BackgroundColor$ white��5O   1   $��0��5P   1   $��1��6A   $
 Hand��6O   $	��3 0q�6]       Value  5J   1   �� *	TotalRate+5P   j   �� 5Q      $��Center=�6�   $��12(�6�   ��6    �� *Raters+# [ ! �� StringFormat$! ({0})��6�   5R      �� 5S      $	��Top=�63   $��18(�6H   $
��Bold"�6V   $��10q�6h   " �� 
IsReadOnly" . # �� TextWrapping$
# Wrap=�6�   ��6   �� *	Details+6�   �� 5T      -
   5        $ borderVideo��5T      $��1q�6.   ���	#FF000000$ 20��6Z   $ �� Padding$$ 1q�6l   $��Center=�5U      $��Center=�62   $	��380��6M   $	��450��6Z   $	��Top=�6f   ��5V      �� 5W      " ��6     5X      �� 5Y   "    6.   �� *Video+# [  true6y   .a�5Z   &   ��  � y�$ 	Collapsed=�6C   5[   #   5]      ._�5_      � .+�5`      �� -   5        $
��mask��5`   !   
������� 6@   �� % �� ElementName$% border��$
 CornerRadius�� 5a      & J� OpacityMask& 5b      !� 5c   "   ' !� Visual' 6.   �� $
% mask��.+�5e      +   %DailyNews.VideoElementNS.VideoElement  (   VideoSource( 62   �� *Video+5f      5g      5h      �� 5i      $	��Top=�6S   $��18(�6h   $
��Bold"�6v   $��10q�6�   $
��Wrap=�6�   ��6   �� *	Comment+$! التعليق: {0}����5j      �� 5k      " ��6     5l      �� 5m   "    6.   �� *	Comment+# [  True6{   .a�5n   &   ��  � y�$ 	Collapsed=�6C   5o   #   5q      5s      5t      5u      � 5v   
   -   5        $ 
ControlBar��5v      ���	#FF673AB7$��2��6:   .+�5w      �� -   5        ) ��Name$) AdminNavigationBarUser��5w      $ 
Horizontal=�69   $
��Left=�6R   .+�5x           DailyNews.ImageButton*   Click$
* Last��6>   +   Source$+ /Icons/LastIcon.png?�6    6>     5y      $
* Next��6>   $+ /Icons/NextIcon.png?�6    6>     5z      $
* Back��6>   $+ /Icons/BackIcon.png?�6    6>     5{      $* First��6>   $+ /Icons/FirstIcon.png?�6    6>   5|      �� 5}      -   5        $) NewsNumberBar��5}      $ 
Horizontal=�60   $��Center=�6I   .+�5~      �� -   5        $ tbkCurrentNewsNumber��5~      $��18(�6�   
�������$��Center=�6�   ��6:   �� *CurrnetNews+# [ 6�   �� 5      -   5        $ tbkTotalNewsNumber��5      $��18(�6�   
�������$��Center=�6�   ��68   �� *
ListLength+# [ $! 
 من {0} ��6�   5�      �� 5�      -   5        $) AdminNavigationBar��5�      $ 
Horizontal=�65   $��Right=�6N   .+�5�        $+ /Icons/AddIcon.png?�6      5�      $* Delete��6?   $+ /Icons/DeleteIcon.png?�6    6?     5�      $
* Edit��6=   $+ /Icons/EditIcon.png?�6    6=   5�      5�      5�      5�      