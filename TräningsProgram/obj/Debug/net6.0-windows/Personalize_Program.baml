   M S B A M L   `   `   `  ����K  GTräningsProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TräningsProgramTräningsProgram  5   	   *    $TräningsProgram.Personalize_Program   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TräningsProgram     5   	     � Title$  Personalize_Program��5   	   $	��450��6%   $	��800��62    � WindowStartupLocation$ CenterScreen=�6>   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$ exerciseListBox��5      $��1��6V   $��2��6f   �� 5    
   $��2��6   $��5��6'   $��2��6;   .��5!      � .+�5"      �� -   5        $ newExercisesListBox��5"      $��	0,0,287,0q�6b   �� 5#      -   5        $ durationListBox��5#      $��152,0,211,0q�6^   �� 5$      -   5        $ RepsListBox��5$      $��228,0,135,0q�6Z   �� 5%      -   5        $ weightListBox��5%      $��
304,0,59,0q�6\   �� 5&      -   5        $ inclineListBox��5&      $��380,0,-17,0q�6]   5'      5(      �� 5)   
   -   5        $ muscleGroupListBox��5)      $��7��6Y   $��2��6i   �� 5+   
   $��  Exersices��6   $��1��6'   $��1��67   $��Bottom=�6D   $
��Bold"�6_   �� 5,   
   $��2��6   $��1��6%   $��Bottom=�62   .+�5-      �� $��Workout name��6   $
��Bold"�6-   �� 5.      -   5         ��Name$ workoutNameTextBox��5.      $��25��62   $
��150 ��6>   $
��Left=�6K   $	��Top=�6f   $��New Workout��6~   5/      �� 51   
   $��
  Duration��6   $��3��6&   $��1��66   $��Bottom=�6C   $
��Bold"�6^   �� 52   
   $��  Reps��6   $��4��6"   $��1��62   $��Bottom=�6?   $
��Bold"�6Z   �� 53   
   $��  Weight��6   $��5��6$   $��1��64   $��Bottom=�6A   $
��Bold"�6\   �� 54   
   $��	  Incline��6   $��6��6%   $��1��65   $��Bottom=�6B   $
��Bold"�6]   �� 55   
   $��  Effected Muscel group��6   $��7��63   $��1��6C   $��Bottom=�6P   $
��Bold"�6k   �� 58   
   $��2��6   $��3��6"    �� Orientation$ 
Horizontal=�62   $	��Top=�6K   �� 59   
   -	   5         ��Name$ AddnewExerciseButton��59      $��1��6/   $��Add New Exercise��6?   $
��Left=�6Z   $��10,0,0,0q�6u   $��4��6�   $��Center=�6�   $	��110��6�   6�   �� 5:   
   -
   5        $" removeFromNewExercisesButton��5:      $��2��67   $��3��6G   $"��Remove Exercise from Workout��6[   $
��Left=�6�   $��10,0,0,0q�6�   $��5��6�   $��Center=�6�   $	��200��6�   6�   �� 5;   
   -   5        $ removeExerciseButton��5;      $��1��6/   $��Remove Exercise��6?   $
��Left=�6Y   $��10,0,0,0q�6t   $��5��6�   $��Center=�6�   $	��110��6�   6�   �� 5<   
   -   5        $ 
SaveButton��5<      $��7��6%   $
��Save��65   $
��Left=�6D   $��10,0,0,0q�6_   $��4��6q   $��Center=�6~   $	��110��6�   6�   �� 5=   
   -   5        $ CancelButton��5=      $��7��6'   $��Cancel��67   $
��Left=�6H   $��10,0,0,0q�6c   $��5��6u   $��Center=�6�   $	��110��6�   6�   �� 5>   
   -   5        $# AddexerciseTonewWorkoutButton��5>      $��2��68   $��3��6H   $��Add Exercise to Workout��6\   $
��Left=�6~   $��10,0,0,0q�6�   $��4��6�   $��Center=�6�   $	��200��6�   6�   5@      5B      