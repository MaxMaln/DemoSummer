   M S B A M L   `   `   `  ����I  EDemo2022summer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Demo2022summerDemo2022summer  5   	       Demo2022summer.Ticket   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Demo2022summer     5   	     � Title$  Билеты��5   	   $	��498��6   $	��940��6%    � WindowStartupLocation$ CenterScreen=�61    � Icon$ 	/icon.png��6V    � 
ResizeMode$ CanMinimize=�6g   .��5	      � #��� ��6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrig��5
         AutoGenerateColumns .  $��10,67,10,10q�6A   $��Comic Sans MS)�6V      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 140 6@   	   Header$	 Номер билета��6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *number+6d     5      $ 70 6?   $	 
Сеанс��6J   
 6%   �� *seans+6[     5      $ 70 6=   $	 Зал��6H   
 6%   �� *zal+6W     5      $ 70 6?   $	 
Место��6J   
 6%   �� *mesto+6[     5      $	 100 6>   $	 Цена��6J   
 6%   �� *zena+6Z     5      $	 160 6>   $	 
Фильм��6J   
 6%   �� *film+6[     5      $#	 Описание фильма��6B   
 6%   �� *
opisanie+6]   5      �� 5   
   $
��Left=�6   $��62��6+   $��17,0,0,0q�67   $	��Top=�6I   $��76��6a   $��	/icon.png��6l   �� 5   
   -   5         ��Name$ 
welcomebox��5      $
��Left=�6(   $��	84,19,0,0q�6C   $
��Wrap=�6V   $�� ��6j   $	��Top=�6r   $��35��6�   $	��195��6�   $��Comic Sans MS)�6�   $��14(�6�   �� 5   
   -   5        $��Обновить��5      $
��Left=�6$   $��
837,13,0,0q�6?   $	��Top=�6S   $��32��6k   $��81��6w   $��14(�6�   $��Comic Sans MS)�6�   ���	#FF56A9E8��6�   Z� 6�   �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
595,13,0,0q�6?   $	��Top=�6S   $��32��6k   $��81��6w   $��14(�6�   $��Comic Sans MS)�6�   ���	#FF56E89E��6�   Z� 6�   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��
717,13,0,0q�6>   $	��Top=�6R   $��32��6j   $��81��6v   $��14(�6�   $��Comic Sans MS)�6�   ���	#FFE85690��6�   Z� 6�   �� 5   
   -   5        $��Изменить��5      $
��Left=�6$   $��
470,13,0,0q�6?   $	��Top=�6S   $��32��6k   $��81��6w   $��14(�6�   $��Comic Sans MS)�6�   ���	#FFD1E856��6�   Z� 6�   5      5      