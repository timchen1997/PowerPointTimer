   M S B A M L   `   `   `  ���� J  FPowerPointTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PowerPointTimerPowerPointTimer  (    "PowerPointTimer.SpecificFileWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:PowerPointTimer       � Title$  Presentations��$	��300��$	��480�� � 
ResizeMode$ NoResize=�.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��249��$	��372��   AutoGenerateColumns .     CanUserReorderColumns .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ FilePath��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 220 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Path+	   ClipboardContentBinding	 Z�   $
 Hour�� �� *Hour+	 Z�   $ Minute�� �� *Minute+	 Z�   $ Second�� �� *Second+	 Z� �� -   
 ��Name$
 btnAdd��$	��Add��$
��Left=�$��
387,10,0,0q�$	��Top=�$��75���� -   $
 btnClose��$��Close��$
��Left=�$��387,240,0,0q�$	��Top=�$��75���� -   $
 	btnRemove��$��Remove��$
��Left=�$��
387,34,0,0q�$	��Top=�$��75��