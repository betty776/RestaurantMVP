   M S B A M L   `   `   `  ����@  <Tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Tema3.View
Tema3.View  5   	       Tema3.View.Menu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Tema3.View     5   	     � Title$
  Menu��5   	   $	��450��6   $	��800��6#   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��30��6   $��30��6!   $��5q�6,   $
��Left=�67   
������ 
������ $��0q�5   H   ��5   R   �� *ProductByPattern+5      �� 5      $��30��6   $	��165��6"   $��Right=�6.   $��5q�6J   $��Center=�6U   ��5      �� *	Pattern+�� 5      $��30��6   $��50��6!   $��3q�6,   $��1��67   $	��All��6G   $
��Left=�6U   ��5      �� *	AllFood+�� 5      $��30��6   $��50��6!   $��3q�6,   $��1��67   $��	Garnituri��6G   $
��Left=�6[   $��	Garnituri��5   <   ��6   �� *ProductsByCategory+6<   �� 5      $��30��6   $��50��6!   $��3q�6,   $��1��67   $
��Supe��6G   $��Center=�6V   $
��Supe��5   <   ��6   �� *ProductsByCategory+6<   �� 5      $��30��6   $��50��6!   $��3q�6,   $��2��67   $��Salate��6G   $
��Left=�6X   $��Salate��5   <   ��6   �� *ProductsByCategory+6<   �� 5      $��30��6   $��50��6!   $��3q�6,   $��2��67   $��Paste��6G   $��Center=�6W   $��Paste��5    <   ��6   �� *ProductsByCategory+6<   �� 5!      $��30��6   $��50��6!   $��3q�6,   $��2��67   $��Pizza��6G   $��Right=�6W   $��Pizza��5"   <   ��6   �� *ProductsByCategory+6<   �� 5#      $��30��6   $��50��6!   $��3q�6,   $��3��67   $��Desserts��6G   $
��Left=�6Z   $��Desserts��5$   <   ��6   �� *ProductsByCategory+6<   �� 5%      $��30��6   $��50��6!   $��3q�6,   $��3��67   $��Drinks��6G   $��Center=�6X   $��Drinks��5&   <   ��6   �� *ProductsByCategory+6<   �� 5'      $��30��6   $��57��6!   $��3q�6,   $��3��67   $��Menus��6G   $��Center=�6W   ��5(      �� *Meniu+5)      &   System.Windows.Controls.DataGrid  5+   
   $��1��6   $��4��6    $��5q�64      AutoGenerateColumns .     
IsReadOnly . 
�������"   VerticalScrollBarVisibility$ Visible=�5-   9   ��5,      �� *	Produse+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5-      �� *SelectedItem+   Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Nume��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 170 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *
Item1.Nume+  50      $
	 Pret��6%   $
 70 64    6?   �� *
Item1.Pret+ �� StringFormat$ c��  51      $	 	Cantitate��6%   $
 60 69    6D   �� *Item1.Cantitate+  52      $	 	Categorie��6%   $	
 180 69    6E   �� *
Item2.Nume+  53      $	 Alergen��6%   $	
 150 67    6C   �� *
Item3.Nume+4  .System.Windows.Controls.DataGridTemplateColumn  54      56      58      5:      5;      