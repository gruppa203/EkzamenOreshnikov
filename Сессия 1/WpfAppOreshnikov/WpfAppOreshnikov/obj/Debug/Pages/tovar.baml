   M S B A M L   `   `   `  ����K  GWpfAppOreshnikov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfAppOreshnikov.PagesWpfAppOreshnikov.Pages  5      "    WpfAppOreshnikov.Pages.tovar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WpfAppOreshnikov.Pages     5        N� Title$  tovar��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��30* �6   �� 5      $	��10* �6   �� 5      $
��350* �6   �� 5      $	��10* �6   �� 5      $	��30* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $
��150* �6   �� 5      $	��40* �6   �� 5      $
��150* �6   �� 5      $	��40* �6   �� 5      $
��150* �6   �� 5      $��40 �6   �� 5      $
��150* �6   �� 5      $	��40* �6   .+�5    
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	grid_Data��5       $��7��6&   $��1��6:   $��3��6J      AutoGenerateColumns .     
IsReadOnly .    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6%   	   Header$	 Артикул��62   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6C   �� *	artikul+  5#      $
 auto 6%   $	 Наименование��62   
 6H   �� *naimemovanie+  5$      $
 auto 6%   $	 ед. изм��62   
 6C   �� *ed_izmereniya+  5%      $
 auto 6%   $	 Стоимость��62   
 6E   �� *
stoimost+  5&      $
 auto 6%   $%	 Возможная скидка��62   
 6L   �� *vozmojnaya_skidka+  5'      $
 auto 6%   $ 	 Производитель��62   
 6I   �� *proizvoditel+  5(      $
 auto 6%   $	 Поставщик��62   
 6E   �� *	postavsik+  5)      $
 auto 6%   $	 Категория��62   
 6E   �� *
kategoriya+  5*      $
 auto 6%   $	 Скидка��62   
 6B   �� *skidka+  5+      $
 auto 6%   $	 Количество��62   
 6F   �� *kolichestvo+  5,      $
 auto 6%   $	 Описание��62   
 6D   �� *
opisanie+  5-      $
 auto 6%   $	 Изображение��62   
 6G   �� *izobrajenie+5/      �� 50   
   -   5         ��Name$ btn_back��50      $��
Назад��6#   $��7��63   $��5��6C   6P   �� 51   
   -   5         ��Name$ sort_box��51      $��1��6%   $��1��65   �� 52   
   -   5        $ 	filtr_box��52      $��3��6&   $��1��66   �� 53   
   -   5         ��Name$ lbl_kol��53      $��7��6!   $��1��61   55      56      