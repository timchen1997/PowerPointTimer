   M S B A M L   `   `   `  ����W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U<clr-namespace:System.Windows.Input;assembly=PresentationCoreSystem.Windows.Input  5   	   J FPowerPointTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PowerPointTimerPowerPointTimer 5   	   #   PowerPointTimer.SettingWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   Ninput<clr-namespace:System.Windows.Input;assembly=PresentationCore      5   	   /localclr-namespace:PowerPointTimer      5   	   -   5          � Title$  Settings��5	   	   $	��300��6   $	��300��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6v   .��5
      � .+�5   
   �� -   5         ��Name$ label��5      $��Settings��6   $
��Left=�62   $��	10,10,0,0q�6M   $	��Top=�6`   $��32(�6x   �� 5   
   -   5        $ label1��5      $��Countdown length��6    $
��Left=�6;   $��	10,66,0,0q�6V   $	��Top=�6i   �� 5   
   -   5         ��Name$
 hour��5      $
��Left=�6    $��23��6;   $��
144,66,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $��0��6o   $	��Top=�6x   $��21��6�    �� IsInputMethodEnabled .  6�   �� 5   
   -   5        $ label1_Copy��5      $��:��6%   $
��Left=�61   $��
165,66,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ minute��5      $
��Left=�6"   $��23��6=   $��
178,66,0,0q�6I   $
 Wrap=�6]   $��5��6q   $	��Top=�6z   $��21��6�    .  6�   �� 5   
   -   5        $ label1_Copy1��5      $��:��6&   $
��Left=�62   $��
199,66,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ second��5      $
��Left=�6"   $��23��6=   $��
212,66,0,0q�6I   $
 Wrap=�6]   $��0��6q   $	��Top=�6z   $��21��6�    .  6�   �� 5   
   -	   5         ��Name$ button��5      $
��Save��6!   $
��Left=�60   $��207,240,0,0q�6K   $	��Top=�6`   $��75��6x   6�   �� 5   
   -
   5        $ label1_Copy2��5      $��Default location��6&   $
��Left=�6A   $��	10,96,0,0q�6\   $	��Top=�6o   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��144,100,0,0q�6@   $	��Top=�6U   $	��120��6m   	 �� SelectedIndex$	 0��6y   .@�5      �� $��Topleft��6   �� 5      $��Topright��6   5      �� 5   
   -   5        $ btnSpecific��5      $0��*Set up different length for specific files��6&   $
��Left=�6[   $��
10,156,0,0q�6v   $	��Top=�6�   $	��272��6�   6�   5      5      