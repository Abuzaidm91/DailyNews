   M S B A M L   `   `   `  ����D  @DailyNews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DailyNews.VideoElementNSDailyNews.VideoElementNS  5   	   1clr-namespace:DailyNews.ViewsDailyNews.Views  5   	   ;"clr-namespace:DailyNews.ConvertersDailyNews.Converters  5   	   K*clr-namespace:DailyNews.StarRatingsControlDailyNews.StarRatingsControl  5	   	   %clr-namespace:DailyNews	DailyNews  5
   	   ,    &DailyNews.Views.frmViewSocialMediaPost   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8video&clr-namespace:DailyNews.VideoElementNS     5   	   /localclr-namespace:DailyNews.Views     5   	   9
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
   � -   5         �Name$ TitleBar��5/      $��30��6"   $	��Top=�6/   
���  ��.+�50      �� -   5         ��Name$ btnClose��50       � Cursor$
 Hand��6(     TitleBarButtons#��[ 6M   $��Right=�6w   .��51      �� $#��/Resource/close-window-48.png��6   52      53      �� 54   
   $��Visible=�6   $��1��6>   .��55      ]� ��.  .+�56      �� -   5         ��Name$ Title��56      $	��Top=�6+   $��Center=�6W    �� TextAlignment$ Center=�6t   $��30(�6�   $��	ExtraBold"�6�   $
��Wrap=�6�   ��6@   �� *Title+6�   �� 57      -   5        $
 Date��57      $	��Top=�6*   $��LeftToRight=�6�   $ Right=�6�   
���  ��$
��10 2q�6�   ��6@   �� *DateAndTime+  ConvertToEeasternNumbers �� 	Converter# [ 6�   �� 59      -   5         ��Name$ Images��59      $	��Top=�6/   $��Center=�6D   ��5:      �� 5;      .R�5<      ��  ��Name$ 	ImageShow��6%    �� CornerRadius$ 5��68   $	��400��6I   $	��600��6V   $��LeftToRight=�6e   $
��0 10q�6�   ��5=   "   �� 5>   &    �� ImageSource 61   �� 5@      5A      ��5C      �� 5D      .R�5E      ��  �� Orientation$ Vertical=�6)   5F      5H      �� 5L      $	��Top=�6S   $��18(�6h   $
��Bold"�6v   $��10q�6�   $
��Wrap=�6�   ��6   �� *	Comment+ �� StringFormat$ التعليق: {0}����5M      �� 5N      " ��6     �� Triggers 5O      �� 5P   "    �� Binding 6.   �� *	Comment+  ConvertToNullOrEmpty# [  �� Value True6{   .a�5Q   &   ��  � y�$ 	Collapsed=�6C   5R   #   5T      5V      5W      5X      � 5Y   
   -   5        $ 
ControlBar��5Y      
���  ��$��2��68   .+�5Z      �� -   5         ��Name$ AdminNavigationBarUser��5Z      $ 
Horizontal=�69   $
��Left=�6R   .+�5[           DailyNews.ImageButton   Click$
 Last��6>      Source$ /Icons/LastIcon.png?�6    6>     5\      $
 Next��6>   $ /Icons/NextIcon.png?�6    6>     5]      $
 Back��6>   $ /Icons/BackIcon.png?�6    6>     5^      $ First��6>   $ /Icons/FirstIcon.png?�6    6>   5_      �� 5`      -	   5        $ NewsNumberBar��5`      $ 
Horizontal=�60   $��Center=�6I   .+�5a      �� -
   5        $ tbkCurrentPostNumber��5a      $��18(�6�   
�������$��Center=�6�   ��6:   �� *CurrnetNews+# [ 6�   �� 5b      -   5        $ tbkTotalPostNumber��5b      $��18(�6�   
�������$��Center=�6�   ��68   �� *
ListLength+# [ $ 
 من {0} ��6�   5c      �� 5d      -   5        $ AdminNavigationBar��5d      $ 
Horizontal=�65   $��Right=�6N   .+�5e        $ /Icons/AddIcon.png?�6      5f      $ Delete��6?   $ /Icons/DeleteIcon.png?�6    6?     5g      $
 Edit��6=   $ /Icons/EditIcon.png?�6    6=   5h      5i      5j      5k      