   M S B A M L   `   `   `  ����F  BLibraryGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LibraryGame.PagesLibraryGame.Pages  5          LibraryGame.Pages.Edit   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:LibraryGame.Pages     5        N� Title$
  Edit��5	         Page-background#��[  6    � 	Resources 5       �� 
TargetType  Label-format1 �� Property �� Value  Button-margin  TextBox-format��%�  &	       &	 �     &	 �     �� 5   
   " ��6   .�5      ��  � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 25(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 10 15 10 15q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ Italic$�6*   �� 5       � ��$ Light"�6+   �� 5       � ��$ 25��6'   �� 5       � ��$	 175��6&   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5       �� 5!      �� 5"      �� 5#       � RowDefinitions 5%   
   �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      .+�5-   
   �� -   5         ��Name$ 
LabelTitle��53      $��1��5-      $��2��5.      $��Edit a game��5/      $��40(�50      $��Center=�51      $��Center=�52      53      �� 55   
   $��1��6   $��1��56      $��Title :��57      #��[ 58      �� 59   
   $��1��6   $��2��5:      $��Genre :��5;      #��[ 5<      �� 5=   
   $��1��6   $��3��5>      $��Publisher :��5?      #��[ 5@      �� 5A   
   $��1��6   $��4��5B      $��Release Date :��5C      #��[ 5D      �� 5F   
   -   5         ��Name$ 
BackButton��5L      $��1��5F      $��5��5G      $
��Back��5H      #��[ 5J      
���z���5L      �� 5M   
   -   5        $ 
EditButton��5S      $��2��5M      $��5��5N      $
��Edit��5O      #��[ 5Q      
����+��5S      �� 5U   
   -   5        	 ��Name$	 
Tbox_title��5Y      $��2��5U      $��1��5V      #��[ 5W      $��Enter title��5X      5Y      �� 5Z   
   -   5        $	 
Tbox_genre��5^      $��2��5Z      $��2��5[      #��[ 5\      $��Enter genre��5]      5^      �� 5_   
   -   5        $	 Tbox_publisher��5c      $��2��5_      $��3��5`      #��[ 5a      $��Enter publisher��5b      5c      (  "System.Windows.Controls.DatePicker  5d   
   -   5        
  Name$
 	Tbox_date��5l      $��2��5d      $��4��5e      $��25��5f      $	��175��5g      $��15(�5h      $��Italic$�5i      $��Light"�5j         DisplayDateStart 
01/01/19705k      5l      5m      5n      