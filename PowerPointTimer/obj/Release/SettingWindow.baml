   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U<clr-namespace:System.Windows.Input;assembly=PresentationCoreSystem.Windows.Input  J FPowerPointTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PowerPointTimerPowerPointTimer #   PowerPointTimer.SettingWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      @d2http://schemas.microsoft.com/expression/blend/2008      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      Ninput<clr-namespace:System.Windows.Input;assembly=PresentationCore      /localclr-namespace:PowerPointTimer      -     � Title$  Settings��$	��300��$	��300�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� .+��� -    ��Name$ label��$��Settings��$
��Left=�$��	10,10,0,0q�$	��Top=�$��32(��� -   $ label1��$��Countdown length��$
��Left=�$��	10,66,0,0q�$	��Top=��� -    ��Name$
 hour��$
��Left=�$��23��$��
144,66,0,0q� �� TextWrapping$
 Wrap=�$��0��$	��Top=�$��21�� �� IsInputMethodEnabled .  �� -   $ label1_Copy��$��:��$
��Left=�$��
165,66,0,0q�$	��Top=��� -   $ minute��$
��Left=�$��23��$��
178,66,0,0q�$
 Wrap=�$��5��$	��Top=�$��21�� .  �� -   $ label1_Copy1��$��:��$
��Left=�$��
199,66,0,0q�$	��Top=��� -   $ second��$
��Left=�$��23��$��
212,66,0,0q�$
 Wrap=�$��0��$	��Top=�$��21�� .  �� -	    ��Name$ button��$
��Save��$
��Left=�$��207,240,0,0q�$	��Top=�$��75���� -
   $ label1_Copy2��$��Default location��$
��Left=�$��	10,96,0,0q�$	��Top=��� -    ��Name$ comboBox��$
��Left=�$��144,100,0,0q�$	��Top=�$	��120��	 �� SelectedIndex$	 0��.@��� $��Topleft���� $��Topright���� -   $ btnSpecific��$0��*Set up different length for specific files��$
��Left=�$��
10,156,0,0q�$	��Top=�$	��272��