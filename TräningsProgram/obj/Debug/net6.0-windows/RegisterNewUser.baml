   M S B A M L   `   `   `  ����K  GTräningsProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TräningsProgramTräningsProgram  5   	   &     TräningsProgram.RegisterNewUser   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TräningsProgram     5   	     � Title$  RegisterNewUser��5   	   $	��450��6!   $	��600��6.    � WindowStartupLocation$ CenterScreen=�6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��4* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ backToLogInButton��5   T   $��Copperplate Gothic Bold)�6   $��1��66   $��2��6G   $��Previous��6o   $	��100��6�   $��20��6�   $
��Left=�6�   6�   �� 5   
   -   5        $ saveUserButton��5   T   $��Copperplate Gothic Bold)�6   $��2��66   $��2��6G   $��	Save User��6l   $	��100��6�   $��20��6�   $��Right=�6�   6�   �� 5   
   $��0��6   $��1��6"   $��2��62   $
��Left=�6F   .+�5      �� $��10q�6   $��Register new User��6%   $��Copperplate Gothic Bold)�6>   $��20(�6c   $
��Left=�6q   6�   5      �� 5   
   $��1��6   $��1��6%   .+�5      �� $��
10 10 0 10q�6   $��Bottom=�6,   $��20��6G   $��Copperplate Gothic Bold)�6S   
User Name:6�   �� 5       $��
10 10 0 10q�6   $��Bottom=�6,   $��20��6G   $��Copperplate Gothic Bold)�6S   	Password:6�   �� 5!      $��
10 10 0 10q�6   $��Bottom=�6,   $��20��6G   $��Copperplate Gothic Bold)�6S   Verify Password:6�   5#      � 5$   
   $��2��6   $��1��6    5%      �� 5&      $��40 �6    �� 5'      $��40 �6    �� 5(      $��40 �6    .+�5+      �� -   5         ��Name$ registerUserNameTextBox��5+   ^   $��0��6   $��
5 10 10 10q�6#   $	��Top=�67   $��20��6Q   6^   �� 5,      -   5        $ registerPasswordTextBox��5,   ^   $��1��6   $��
5 10 10 10q�6#   $	��Top=�67   $��20��6Q   6^   �� 5-      -   5        $# registerVerifyPasswordTextBox��5-   ^   $��2��6   $��
5 10 10 10q�6#   $	��Top=�67   $��20��6Q   6^   5/      51      53      