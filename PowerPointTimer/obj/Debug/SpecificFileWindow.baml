   M S B A M L   `   `   `  ����J  FPowerPointTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PowerPointTimerPowerPointTimer  5   	   (    "PowerPointTimer.SpecificFileWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PowerPointTimer     5   	     � Title$  Presentations��5   	   $	��300��6   $	��480��6,    � 
ResizeMode$ NoResize=�68   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5
      $
��Left=�6%   $��	10,10,0,0q�6@   $	��Top=�6S   $	��249��6k   $	��372��6x      AutoGenerateColumns .     CanUserReorderColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ FilePath��6a      Width5  /System.Windows.Controls.DataGridLengthConverter$	 220 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Path+	   ClipboardContentBinding	 6>   Z� 6s     5      $
 Hour��6a    6%   �� *Hour+	 6>   Z� 6a     5      $ Minute��6c    6%   �� *Minute+	 6@   Z� 6c     5      $ Second��6c    6%   �� *Second+	 6@   Z� 6c   5      �� 5   
   -   5        
 ��Name$
 btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
387,10,0,0q�6J   $	��Top=�6^   $��75��6v   6�   �� 5   
   -   5        $
 btnClose��5      $��Close��6#   $
��Left=�63   $��387,240,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $
 	btnRemove��5      $��Remove��6$   $
��Left=�65   $��
387,34,0,0q�6P   $	��Top=�6d   $��75��6|   6�   5      5      