using MySqlX.XDevAPI.Common;
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
using System.Windows.Shapes;

namespace TräningsProgram
{
    /// <summary>
    /// Interaction logic for Edit_Exercise.xaml
    /// </summary>
    public partial class Edit_Exercise : Window
    {
        
        Personalize_Program pp;
        Exercise ex;
        
        List<string> workout;
        List<string> duration;
        List<string> reps;
        List<string> weight;
        List<string> incline;
        


        public Edit_Exercise(Exercise ex, Personalize_Program pp, List<string>Workout, List<string> duration, List<string> reps, List<string> weight, List<string> incline)
        {
            InitializeComponent();
            this.ex = ex;
            this.pp = pp;
            this.workout = Workout;
            this.duration = duration;   
            this.reps = reps;
            this.weight = weight;
            this.incline = incline;
            exerciseLabel.Content = ex.Name.ToString();
            clearAll();

        }
        public void Addreps(Exercise ex)
        {


            if (timeTextBox.Text == "0" && repsTextBox.Text == "0")
            {
                MessageBox.Show("You need to choose a time or a number of reps for the exercise");
            }
            else
            {
                duration.Add(timeTextBox.Text);
                reps.Add(repsTextBox.Text);
                weight.Add(weightTextBox.Text);
                incline.Add(inclineTextBox.Text);
            }
           
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            
            this.Save();
            this.Close();
            
        }
        public void Save()
        {
                Addreps(this.ex);
                workout.Add(ex.Name);
            
            pp.newExercisesListBox.ItemsSource = workout;
            pp.newExercisesListBox.Items.Refresh();
            pp.PresentEffecktedMuscleGroups();
            pp.durationListBox.ItemsSource = duration;
            pp.durationListBox.Items.Refresh();
            pp.RepsListBox.ItemsSource = reps;
            pp.RepsListBox.Items.Refresh();
            pp.weightListBox.ItemsSource = weight;
            pp.weightListBox.Items.Refresh();
            pp.inclineListBox.ItemsSource = incline;
            pp.inclineListBox.Items.Refresh();
        }
        private void clearAll()
        {
            timeTextBox.Text = "0";
            repsTextBox.Text = "0"; 
            weightTextBox.Text = "0";
            inclineTextBox.Text = "0";
        }
 

    }
}
