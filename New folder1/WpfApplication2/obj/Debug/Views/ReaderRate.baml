   M S B A M L   `   `   `  ����D  @DailyNews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DailyNews.StarRatingsControlDailyNews.StarRatingsControl  5   	        DailyNews.Views.ReaderRate   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   IStarRatingsControl*clr-namespace:DailyNews.StarRatingsControl     5   	     � Title$  Window1��5   	   $��80��6   $	��300��6%    � WindowStartupLocation$ CenterScreen=�61    � WindowStyle$
 None=�6V    � 	Resources 5	      1   +DailyNews.StarRatingsControl.RatingsControl   RatingsControl��%   &	          5
   
   6,   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��6*   $��Center=�67   .+�5   
   �� -   5         ��Name$ Slider��5       � Minimum$ 1Q�6>    � Maximum$ 5Q�6J   	 �� TickFrequency$	 1Q�6V   
 �� IsSnapToTickEnabled
 . $	��200��6�   $��Center=�6�   $��5q�6�    � Value 6!   �� *
ReaderRate+6�   �� 5   
   $��5q�60   $��16(�6;   $��Center=�6I   ��6   �� *
ReaderRate+6I   �� 5   
   -   5         ��Name$ Ok��5      $��قيم��6   $��Center=�6+   6F   5        5   
   -   5          Name$ ratings1��5   ,      NumberOfStars$ 5��5   1   $��Center=�5   1      StarOutlineColor$ DarkGray��5   1      StarForegroundColor$ Orange��5   1      BackgroundColor$ white��5   1   $��1��5   1    � Cursor$
 Hand��6?   $	��3 0q�6M      Value 5   1   ��  �� ElementName$ Slider�� �� Path$ Value�5   M   5      5      