   M S B A M L   `   `   `  ����K  GTräningsProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TräningsProgramTräningsProgram  5   	   $    TräningsProgram.Edit_Exercise   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TräningsProgram     5   	     � Title$  Edit_Exercise��5   	   $	��200��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5       $
��1.5* �6   �� 5!      $��* �6   �� 5"      $
��1.5* �6   �� 5#      $��2* �6   .+�5&   
   �� -   5         ��Name$ exerciseLabel��5&      $��2��6'   $��1��64   $��5��6D   $
��Left=�6X   $	��Top=�6t   $
��Bold"�6�   $��Copperplate Gothic Bold)�6�   $	��200��6�   $��20��6�   �� 5(   
   -   5         ��Name$ timeTextBox��5(   7   $��5��6   $��1��6   $�� ��6/    �� TextWrapping$
 Wrap=�6M   $��Copperplate Gothic Light)�6e   �� 5)   
   -   5        $ repsTextBox��5)   7   $��5��6   $��3��6   $�� ��6/   $
 Wrap=�6M   $��Copperplate Gothic Light)�6e   �� 5*   
   -   5        $ weightTextBox��5*   7   $��5��6   $��5��6   $�� ��6/   $
 Wrap=�6O   $��Copperplate Gothic Light)�6e   �� 5+   
   -   5        $ inclineTextBox��5+   7   $��5��6   $��7��6   $�� ��6/   $
 Wrap=�6P   $��Copperplate Gothic Light)�6e   �� 5-   
   -   5        $ 	timeLabel��5-   .   $��4��6   $��1��6   $��Time:��6A   $��Copperplate Gothic Light)�6W   �� 5.   
   -   5        $ 	repsLabel��5.   .   $��4��6   $��3��6   $��Reps:��6A   $��Copperplate Gothic Light)�6U   �� 5/   
   -   5        $ weightLabel��5/   .   $��4��6   $��5��6   $��Weight:��6C   $��Copperplate Gothic Light)�6U   �� 50   
   -	   5        $ inclineLabel��50   .   $��4��6   $��7��6   $��Incline:��6D   $��Copperplate Gothic Light)�6W   �� 52   
   -
   5         ��Name$ 
saveButton��52   .   $��7��6   $��9��6   $
��Save��6B   $	��Top=�6Q   $��Copperplate Gothic Light)�6q   6�   �� 53   
   -   5        $ canselButton��53   /   $��7��6   $��11��6   $��Cancel��6E   $	��Top=�6V   $��Copperplate Gothic Light)�6q   56      57      