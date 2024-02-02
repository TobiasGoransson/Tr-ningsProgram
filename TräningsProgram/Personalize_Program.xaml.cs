using Google.Protobuf.WellKnownTypes;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TräningsProgram
{
    /// <summary>
    /// Interaction logic for Personalize_Program.xaml
    /// </summary>
    public partial class Personalize_Program : Window
    {
        List<Exercise> newWorkout = new List<Exercise>();
        Databas databas = new Databas();
        
        List<string> Workout = new List<string>();
        List<string> duration = new List<string>();
        List<string> reps = new List<string>();
        List<string> Weight = new List<string>();
        List<string> incline = new List<string>();
        List<Exercise> ex;
        Exercise exercise;
        User user;
        private ObservableCollection<string> EffectedMuscleGroup = new ObservableCollection<string>();

        public Personalize_Program(User user)
        {
            InitializeComponent();
           
            this.user = user;
            
        }

        public List<string> GetExercises()
        {
            ex = databas.GetAllExercises();
            List<string> result = new List<string>();
            foreach (Exercise exercise in ex)
            {
                string move = exercise.Name;
                result.Add(move);
            }
            return result;
           
        }


        private Exercise exerciseListBox_SelectionChanged()
        {
            object selectedItem = (object)exerciseListBox.SelectedItem;

            if (selectedItem != null)
            {
                for (int i = 0; i < ex.Count; i++)
                {
                    if (selectedItem.Equals(ex[i].Name))
                    {
                        return ex[i];
                      
                        break;
                    }
                }
            }
            return null;
        }


        private void AddexerciseTonewWorkoutButton_Click(object sender, RoutedEventArgs e)
        {

           Exercise exercise = exerciseListBox_SelectionChanged();
            newWorkout.Add(exercise);
            Edit_Exercise edit_Exercise = new Edit_Exercise(exercise, this, Workout, duration, reps, Weight, incline);
            edit_Exercise.Show();

        }
        private void AddnewExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewExercise addNewExercise = new AddNewExercise(this);
            addNewExercise.Show();
            this.Hide();
        }
        private void removeExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            Exercise exercise = exerciseListBox_SelectionChanged();
            databas.RemoveExercise(exercise);
            List<string> exercises2 = GetExercises();
            exerciseListBox.ItemsSource = null;
            exerciseListBox.Items.Clear();
            exerciseListBox.ItemsSource = exercises2;
            exerciseListBox.Items.Refresh();

        }
        private void NewExercisesListBox_SelectionChanged()
        {
            string selectedItem = (string)newExercisesListBox.SelectedItem;
            if (selectedItem != null)
            {
                for (int i = 0; i < newWorkout.Count; i++)
                {

                    if (selectedItem.Contains(newWorkout[i].Name))
                    {
                        newWorkout.RemoveAt(i);
                    }

                }
                string selectedExercise = selectedItem.ToString();
                if (Workout.Contains(selectedExercise))
                {
                    Workout.Remove(selectedExercise);
                }
                newExercisesListBox.ItemsSource = Workout;
                newExercisesListBox.Items.Refresh();

                PresentEffecktedMuscleGroups();

            }
        }


        private void removeFromNewExercisesButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewExercisesListBox_SelectionChanged();
        }

        public void PresentEffecktedMuscleGroups()
        {
            List<string> EffectedMuscleGroup = new List<string>();

            List<Muscel_Group> muscel_Groups = new List<Muscel_Group>();
            muscel_Groups = databas.GetEffectedMuscelGroups(newWorkout);

            foreach (Muscel_Group group in muscel_Groups)
            {
                string groupName = group.Name.ToString();

                if (!EffectedMuscleGroup.Contains(groupName))
                {
                    EffectedMuscleGroup.Add(groupName);
                }
            }

            muscleGroupListBox.ItemsSource = EffectedMuscleGroup;
            muscleGroupListBox.Items.Refresh();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (workoutNameTextBox.Text == "New Workout")
            {
                MessageBox.Show("You need to choose a name for your workout");
            }
            else
            {
                this.getNewWorkout();
                this.Close();
                Choose_Program choose_Program = new Choose_Program(user);
                choose_Program.Show();
                choose_Program.usernameTextBlock.Text = user.Name;
                choose_Program.ListWorkouts(user);
            }
        }

        public void getNewWorkout()
        {
            string program = workoutNameTextBox.Text;
            List<WorkoutExercises> we = new List<WorkoutExercises>();
            for (int i = 0; i < newExercisesListBox.Items.Count; i++)
            {

                string exerciseName = newExercisesListBox.Items[i].ToString();

                


                int duration = int.Parse(durationListBox.Items[i].ToString());
                int reps = int.Parse(RepsListBox.Items[i].ToString());
                int weight = int.Parse(weightListBox.Items[i].ToString());
                int incline = int.Parse(inclineListBox.Items[i].ToString());
                WorkoutExercises workoutExercise = new WorkoutExercises(exerciseName, duration, reps, weight, incline);
                we.Add(workoutExercise);


            }
            databas.AddWorkout(user, program, we);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this .Close();
            Choose_Program choose_Program = new Choose_Program (user);
            choose_Program.Show (); 
        }
    }
}
