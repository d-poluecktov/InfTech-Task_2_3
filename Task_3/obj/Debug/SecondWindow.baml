   M S B A M L   `   `   `  ����@  <Light, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LightLight  5   	       Light.SecondWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Light     5   	     � Title$  SecondWindow��5   	   $	��450��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��300 �6   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��0��6   $��Assembly Path:��6$   $��Center=�6:   $��Center=�6U   �� 5   
   -   5         ��Name$ AssemblyPathTextBox��5   "   $��1��6   $��5q�6@   �� 5   
   -   5        $��2��5      $��Load Assembly��6!   $��5q�6Z   �� 5   
   -   5         ��Name$ ClassListBox��5      $��1��6(   $��0��65   $��5q�6F   6Q   �� 5   
   -   5        $ MethodsListBox��5      $��1��6*   $��1��67   $��5q�6H   6S   � 5   
   $��1��6   $��2��6!   .+�5      �� -   5        $ ParameterValueTextBox��5      $��50��65   �� 5      -   5        $ ValueTextBox��5       �� 
IsReadOnly . $��50��6>   5      �� 5    
   -   5        $��Execute Method��5       $��5q�6L   $��1��6W   $��3��6d   $��Right=�6t   5!      5"      