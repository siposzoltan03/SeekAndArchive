   M S B A M L   `   `   `  ����M  IRegularExpressions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:RegularExpressionsRegularExpressions  5   	   #    RegularExpressions.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:RegularExpressions     5   	     � Title$  Input validator��5   	   $	��190��6!   $	��410��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   6-   �� 5      $��50 �6   6,   �� 5      $	��310 �6   6-   �� 5      $��20 �6   6,    � RowDefinitions 5   
   �� 5      $��20 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��20 �6   6*   .+�5   
   �� $
��Name��6   $��1��6    $��1��60   $��Center=�6=   6Z   �� 5   
   $��Phone��6   $��1��6!   $��2��61   $��Center=�6>   6[   �� 5   
   $��Email��6   $��1��6!   $��3��61   $��Center=�6>   6[   �� 5   
   -   5        $��txtName��5   J   $��2��6   $��1��6"   $��Center=�6/   6[   �� 5   
   -   5        $��txtPhone��5   J   $��2��6   $��2��6"   $��Center=�6/   6\   �� 5   
   -   5        $��txtEmail��5   J   $��2��6   $��3��6"   $��Center=�6/   6\   �� 5   
   -   5        $��btnSave��5#      $��2��5      $��4��6!   $��Center=�5      $��Right=�5       $	��150��5!      $��20��6   $
��Save��5"      5#   8   5$      5%      