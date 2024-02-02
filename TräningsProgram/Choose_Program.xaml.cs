using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace TräningsProgram
{
    /// <summary>
    /// Interaction logic for Choose_Program.xaml
    /// </summary>
    public partial class Choose_Program : Window
    {
        Databas databas = new Databas();
        User user;
        Program program;
        List<Program> Programs;
        public Choose_Program(User user)
        {
            InitializeComponent();
            this.user = user;
            ListWorkouts(user);
        }
        public void ListWorkouts (User user)
        {
            Programs = databas.GetAllPrograms(user);
            List<string> workouts = new List<string>(); 
            foreach (Program program in Programs) 
            {
                string workout = program.Name;
                workouts.Add(workout);
            }
            WorkoutsListBox.ItemsSource = workouts;
            WorkoutsListBox.Items.Refresh();

        }

        private void newWorkoutButton_Click(object sender, RoutedEventArgs e)
        {
            Personalize_Program pProgram = new Personalize_Program( user);
            pProgram.Show();
            pProgram.exerciseListBox.ItemsSource = pProgram.GetExercises();
            this.Close();
        }
        private void WorkoutsListBox_SelectionChanged()
        {
            object selectedItem = (object)WorkoutsListBox.SelectedItem;

            if (selectedItem != null)
            {
                for (int i = 0; i < Programs.Count; i++)
                {
                    if (selectedItem.Equals(Programs[i].Name))
                    {
                        PopulateRunWorkout(Programs[i]);

                        break;
                    }
                }
            }
        }
        private void chooseWorkout_Click(object sender, RoutedEventArgs e)
        {


            WorkoutsListBox_SelectionChanged();
            this.Close();

        }
        public void PopulateRunWorkout(Program program)
        {
            List<string> rows = new List<string>();
            List<string> duration = new List<string>();
            List<string> exs = new List<string>();
            List<WorkoutExercises> we = databas.GetWorkout(program);
            for (int i = 0; i < we.Count; i++)
            {
                string ex = we[i].ExerciseName.ToString();

                exs.Add(ex);

                if (we[i].duration != 0)
                {
                    duration.Add("Time:" + we[i].duration.ToString());
                }
                if (we[i].reps != 0)
                {

                    duration.Add("Reps:" + we[i].reps.ToString());
                }
                if (we[i].weight != 0)
                {

                    duration.Add("Weight:" + we[i].weight.ToString());
                }
                if (we[i].incline != 0)
                {

                    duration.Add("Incline:" + we[i].incline.ToString());
                }

            }
                

            
            RunWorkout runWorkout = new RunWorkout(user);
            
            runWorkout.exerciseListBox.ItemsSource = exs ;
            runWorkout.durationListBox.ItemsSource = duration ;
            runWorkout.Show();
        }

    }
}
