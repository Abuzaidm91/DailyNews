   M S B A M L   `   `   `  ����D  @DailyNews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DailyNews.ViewsDailyNews.Views  5   	       DailyNews.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   )localclr-namespace:DailyNews.Views  5   	     � WindowStyle$
  None=�5	   	    � Title$ 
MainWindow��5
   	    � WindowState$ 	Maximized=�6    � 
ResizeMode$ NoResize=�65   
���   � � WindowStartupLocation$ CenterScreen=�6`   
�������.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��0��5      ��5      �� 5      .��5      �  � Color$ #6c4d9b��6#    � Offset$ 1Q�63   � 5      $ 	#FF66D5E0��6#   $	 0.5Q�65   � 5      $ #88b6cc��6#   $ 0Q�63   5      .+�5      �  � ColumnDefinitions 5      �� 5      $	��350��6'   $
��auto �66   �� 5      $��* �6'   �� 5      $	��350��6'   $
��auto �66   .+�5      �� .+�5       �� -   5        	 ��Name$	 TitleBar��5    "   $��0��64   
 �� Orientation$
 
Horizontal=�6E   $��30��6^   $
��Left=�6j   .+�5!      �� -   5         ��Name$ btnClose��5!   "    � Cursor$
 Hand��64      TitleBarButtons#��[  6Y   .��5"      �� $#��/Resource/close-window-48.png��6$   5#      �� 5$      -   5        $ btnMaximizeRestore��5$   "   $
 Hand��6>   #��[  6m   .��5%      �� -   5         ��Name$ imgMaximizeRestore��5%   $   $%��/Resource/restore-window-48.png��6A   5&      �� 5'      -   5        $ btnMinimize��5'   "   $
 Hand��67   #��[  6_   .��5(      �� $&�� /Resource/minimize-window-48.png��6$   5)      5*      �� 5+      $��2q�6   $��80��6)   
���� ��$
��Left=�6H   $��50��6c   $��3q�6q   .��5,      �� دراسات�� 6,   وترجمات6@   5-      5.      �� 50      $��1��6   $��Center=�6-   .+�51      �� $��/Images/ByNameOfAllah.png��6    �� BitmapScalingMode$
 Fant=�6?   $
��Fill=�6f   $	��160��6u   $��40��6�   �� 52      $��/Images/JAF logo.png��6   $ HighQuality=�6:   $
��Fill=�6h   $	��140��6x   $	��120��6�   �� 53      $f��`نظام ملخص الاخبار ونشاطات التواصل الاجتماعي اليومية��6    ���	#FF2A632F$��	ExtraBold"�6s   $��16(�6�   54      �� 56      $��2��6   $��	0 10 10 0q�6-   $��RightToLeft=�6@   .+�57      �� $
 
Horizontal=�6!   .+�58      �� $��/Icons/Username.png��6    $��35��6=   $��35��6H   $��Center=�6T   �� 59      $(��"الوكيل أحمد أبوزيد��6$   $��Center=�6>   $��17(�6Y   $��7q�6g   $��DemiBold"�6r   
�������6�   5:      �� 5;      $
 
Horizontal=�6!   $
��Left=�6:   $��	35 0 0 0 q�6U   .+�5<      �� -   5         ��Name$ notification��5<   !   $
 Hand��67   $��33��6E   $��35��6P   $��0 0 20 0q�6\   $��Right=�6n   ._�5=      � .+�5>   "   ��  K� ZIndex$ 0��6)   $	��4 0q�6:   $��25��6H   $��25��6S   ��5?   &   �� 5@   *    �� ImageSource$! /Icons/notificationIcon.png��65   5B   #   �� 5C   "   $
��auto��6)   $��Bottom=�66   $
��Left=�6Q   $
��auto��6l   
���  ��$ 1��6�    �� Padding$	 4 1q�6�    �� CornerRadius$ 5��6�   ._�5D   &   �� $��9��60   $��10(�69   $
��Bold"�6G   5E   #   5F      5G      �� 5I      -   5        $ btnFavorite��5I       $.��(/Icons/FavouritesFolderIconWiteBlack.png��65   $��20 0 0 0q�6h   $��35��6z   $
 Hand��6�   6�   5J      �� 5K      $
 
Horizontal=�6!   $��Bottom=�6:   $��0 5 0 0q�6U   .+�5L      �� $��/Icons/calenderIcon.png��6    $��35��6A   $��Center=�6L   �� 5M      -	   5         ��Name$ DateAndTimeNow��5M   $   
�������$��16(�6T   $��Center=�6b   $��DemiBold"�6}   $��5 0 0 0q�6�   5N      5O      5Q      � 5S      -
   5         �Name$ 
buttonsBar��5S      $
��auto��6'    5T      �� 5U      $��* �6'   �� 5V      $��* �6'   .+�5X      �� -   5        $ 	btnTweets��5X      $��18(�6,   $
 Hand��6:   
���  ��$4��.نشاطات التواصل الاجتماعي��6_   $��0��6�   $��10q�6�   �� 5Y      -   5        $ btnNews��5Y      $��18(�6+   $
 Hand��69   $��الاخبار��6G   $��1��6Y   $��10q�6i   5Z      5[      � 5]   
   -   5        $ Content��5]      $��1��6    
�������$��10q�6@    5^      �� 5_      $��* �6#   �� 5`      $��* �6#   .+�5b      $   DailyNews.Views.frmSocialMedia  -   5          Name$ SocialMedia��5b   #   $��0��68      DailyNews.Views.frmNews  5c      -   5          Name$
 News��5c      $��1��6*   5d      5e      5f      