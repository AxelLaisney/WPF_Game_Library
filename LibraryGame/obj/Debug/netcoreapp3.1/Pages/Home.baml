   M S B A M L   `   `   `  ����F  BLibraryGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LibraryGame.PagesLibraryGame.Pages  5          LibraryGame.Pages.Home   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:LibraryGame.Pages     5        N� Title$
  Home��5	         Page-background#��[  6    � 	Resources 5       �� 
TargetType  
Btn-style1 �� Property �� Value��%   &	       �� 5   
   " ��6   .�5      ��  � ��$ 	5 15 5 15q�6'   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ GameGrid��5       $��1��5      $��0��5      $��3��5      $	��400��5!      $	��600��5"      
������ $��0q�5$      $
��True��5%      $
��Auto=�5&      ��5'      �� 5(      .R�5)      �� $
��auto��6!    �� Orientation$ Vertical=�6/   .+�5*      �� $��0��6=   $	��100��6J   $	��100��6W   ��6    �� *	GameCover+6W   �� 5+      $��1��6:   ��6    �� *Title+6:   5,      5-      5/      �� 51      -   5        	 ��Name$	 
LabelTitle��51      $��My Games Library��52      $��0��53      $��0��54      $��3��55      $��Center=�56      $��Center=�57      $��40(�58      � 5:   
   $��2��6   $��1��6    5;      �� 5<      �� 5=      �� 5>      .+�5@      �� -   5        
 ��Name$
 AddGameButton��5@   J   $��0��6   $��Add game��6%   #��[ 6a   �� 5A      -   5        $
 EditGameButton��5A   L   $��1��6   $��	Edit game��6%   #��[ 6d   �� 5B      -   5        $
 DeleteGameButton��5B   P   $��2��6   $��Delete game��6%   #��[ 6j   5C      5D      5E      