   M S B A M L   `   `   `  ����D  @DailyNews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DailyNew.ViewsDailyNew.Views  5   	   %    DailyNew.Views.CustomMessageBox   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DailyNew.Views     5   	     � Title$  
MessageBox��5   	   $	��150��6   $	��350��6)    � WindowState$ Normal=�65    � WindowStyle$
 None=�6J    � 
ResizeMode$ NoResize=�6]   $��RightToLeft=�6s   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6   ���	#FF673AB7._�5      �� -   5        $��/Icons/CancelIcon.png��5      $��20��64   $��Right=�6@    � Cursor$
 Hand��6\   $��5q�6j   6u   5      �� 5   
   -   5         ��Name$ Image��5      $��0��6   $��1��6/   $��55��6<   $��55��6G   $��Center=�6S   �� 5   
   $��1��6   $��1��6%   .+�5      �� -   5         ��Name$ tbkTitle��5      $��17(�6*   
����p��$	��0 5q�6S   �� 5      -   5        $ tbkDescription��5      $��15(�60   
����p��$	��0 5q�6Z   5      5      5      