   M S B A M L   `   `   `  ����K  GTräningsProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TräningsProgramTräningsProgram  5   	   %    TräningsProgram.Choose_Program   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TräningsProgram     5   	     � Title$  Choose_Program��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��40 �6   �� 5      $	��150 �6   �� 5      $	��100 �6   �� 5      $��30 �6   .+�5   
   �� $��0��6   $��1��6"   $��3��62   $
��Left=�6F   .+�5      �� $��10q�6   $��Choose a Workout��6%   $��Copperplate Gothic Bold)�6=   $��20(�6b   $
��Left=�6p   6�   �� 5      -   5         ��Name$ usernameTextBlock��5      $��Arial Rounded MT Bold)�63   $��20(�6V   $��10,10,10,10q�6d   5      �� 5   
   $��1��6   $��1��6"   $��Center=�62   .+�5      �� $��Copperplate Gothic Bold)�6   .��69   
Workouts6D   5      �� 5    
   $��2��6   $��1��6"   .+�5"      �� -   5         ��Name$ WorkoutsListBox��5"      $��Copperplate Gothic Bold)�6Z   $
��Auto=�6   5$      �� 5%   
   -   5         ��Name$ chooseWorkout��5%   B   $��2��6   $��2��6   $��3��6.   $��Copperplate Gothic Bold)�6Z   $��16(�6   $��36��6�   $	��182��6�   4  .System.Windows.Automation.AutomationProperties   Name$  ��6�   $��Choose Workout ��6�   $��	10,10,0,0q�6�   $	��Top=�6�   $
��Left=�6  6"  �� 5&   
   $��3��6   $��2��6"   $��2��62   $
��Left=�6F   .+�5'      �� -   5        $ newWorkoutButton��5'      $��10q�6/   $��Copperplate Gothic Bold)�6=   $��16(�6b   $
��Left=�6p   $��36��6�   $	��182��6�   $  ��6�   $��New Workout��6�   6�   5)      �� 5*   
   $��3��6   $��1��6"   .+�5+      �� $��/Personalize.jpg��6   5-      5.      5/      50      