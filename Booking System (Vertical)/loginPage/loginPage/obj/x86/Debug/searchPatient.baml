   M S B A M L   `   `   `  ����  	loginPage    loginPage.searchPatient   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6K   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   -   5          � Title$  Select Patient��5   	   $	��305��6    $	��405��6-    � Topmost .  � 
ResizeMode$ NoResize=�6H    � WindowStartupLocation$ CenterScreen=�6^   .��5      � -   5         �Name$ searchPatientBox��5      $��0,0,0,-0.257q�6"   ���	#FFE5E5E5.+�5      �� $
��Left=�6   $��8,0,0,0q�6)   $
��Wrap=�6:   $��Select Patient��6N   $	��Top=�6d   $��16(�6|   �� 5      $
��Left=�6   $��8,21.28,0,0q�6)   $
��Wrap=�6>   $��	Last Name��6R   $	��Top=�6c   �� 5      -   5        $��searchLastName��5   �   $��8,41.24,0,0q�6    �� TextWrapping$
 Wrap=�6!   $	��Top=�65   $��19.96��6M   $
��Left=�6\   $��178.967��6w   $�� ��6�   6�   �� 5   
   -   5         ��Name$ selectButton��5      $��Select��6'   $��Right=�68   $��	0,0,28,11q�6T   $��Bottom=�6g   $��75��6�   $��24��6�   6�   �� 5      -   5        $��searchButton��5   q   $��Search��6   $��Right=�6   $��0,39.24,28,0q�68   $	��Top=�6N   $��75��6f   6�   �� 5	   
   -   5        $��searchCancelButton��5	   b   $��Cancel��6   $��23��6"   $
��Left=�6.   $��187,242.257,0,0q�6I   $	��Top=�6|   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5
   
   -   5        $��searchDataGrid��5
      $��7,68,28,170q�6)      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Last Name��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 95 68     5      $ 
First Name��6%   $	 95 69     5      $ Address��6%   $		 155 66   5      �� 5   
   -   5        $��searchPatLB��5      $��
7,93,28,50q�6%   5      5      