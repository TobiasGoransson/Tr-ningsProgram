   M S B A M L   `   `   `  ����K  GTräningsProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TräningsProgramTräningsProgram  5   	   %    TräningsProgram.AddNewExercise   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TräningsProgram     5   	     � Title$  AddNewExercise��5   	   $	��600��6    $
��1200��6-    � WindowStartupLocation$ CenterScreen=�6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��9* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��40 �6   .+�5    
   �� -   5         ��Name$ newExerciseTextBox��5       $��1��6.   $��3��6;   $��2��6K   $��Copperplate Gothic Bold)�6_   $��New Exercise name��6�   �� 5!   
   $��1��6   $��1��6   $��Exercise Name��6-   $��Copperplate Gothic Bold)�6E   $��2��6j   �� 5"   
   $��3��6   $��1��6   $��Muscel Groups��6-   $��Copperplate Gothic Bold)�6E   $��2��6j   �� 5#   
   $��3��6   $��3��6   $��Effected Muscel Groups��6-   $��Copperplate Gothic Bold)�6N   �� 5$   
   $��6��6   $��6��6"   $��4��62    �� Orientation$ 
Horizontal=�6F   .+�5&      �� -   5         ��Name$ saveNewExerciseButton��5&      $��Save Exercise��65   $��Copperplate Gothic Bold)�6M   $	��200��6�   $
��Left=�6�   �� 5'      -   5        $ CanselButton��5'      $��Cancel��6,   $��Copperplate Gothic Bold)�6=   $	��200��6c   $
��Left=�6o   $��30,0,0,0q�6�   6�   5(      �� 5*   
   -   5        $ addMuscelGroupButton��5*      $��6��6/   $��1��6<   $��Add Muscel Group��6L   $��Copperplate Gothic Bold)�6g   6�   �� 5+   
   -   5        $ removeMuscelGroupButton��5+      $��6��62   $��3��6?   $��Remove Muscel Group��6O   $��Copperplate Gothic Bold)�6m   6�   �� 5,   
   $��1��6   $��6��6   $��4��6-   $��4��6>   $��
/Bild1.jpg��6R   6j   �� 5.   
   -   5         ��Name$ MuscelGroupListBox��5.      $��1��6Y   $��4��6i   �� 5/   
   -   5        $  effectedMuscelGroupListBox��5/      $��3��6a   $��4��6q   51      52      