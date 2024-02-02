using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.X509.SigI;
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
    /// Interaction logic for AddNewExercise.xaml
    /// </summary>
    public partial class AddNewExercise : Window
    {
        Databas Databas= new Databas();
        List<Muscel_Group> muscel_Groups;
        List<Muscel_Group> Groups = new List<Muscel_Group>();       

        List<string> muscel_Name = new List<string>();
        List<string> selectedMuscelName = new List<string>();
        Personalize_Program personalize_Program;

        public AddNewExercise(Personalize_Program personalize_Program)
        {
            InitializeComponent();
            this.personalize_Program = personalize_Program;
            GetMuscelGroup();
        }
        public void GetMuscelGroup()
        {
            muscel_Groups = Databas.GetAllMuscelGroups();
            foreach (Muscel_Group mg  in muscel_Groups)
            {
                string Name = mg.Name.ToString();
                muscel_Name.Add(Name);
            }

            MuscelGroupListBox.ItemsSource = muscel_Name;
        }
 
        private void exerciseListBox_SelectionChanged()
        {
            object selectedItem = (object)MuscelGroupListBox.SelectedItem;

            if (selectedItem != null)
            {
                for (int i = 0; i < muscel_Groups.Count; i++)
                {
                    if (selectedItem.Equals(muscel_Groups[i].Name))
                    {
                        selectedMuscelName.Add (muscel_Groups[i].Name);

                       
                        break;
                    }
                }
                effectedMuscelGroupListBox.ItemsSource = selectedMuscelName;
                effectedMuscelGroupListBox.Items.Refresh();
            }
        }

        private void addMuscelGroupButton_Click(object sender, RoutedEventArgs e)
        {
            exerciseListBox_SelectionChanged();
        }


        private void saveNewExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            string exerciseName = newExerciseTextBox.Text;
            List<Exercise> ex = Databas.GetAllExercises();
            for (int i = 0; i < ex.Count; i++)
            {
                if (exerciseName == ex[i].Name)
                {
                    MessageBox.Show("Choose another name this name already used");
                }
            }

            if (exerciseName == "New Exercise name")
            {
                MessageBox.Show("Choose a name for the Exercise");
            }
            else
            {
                Muscel_Group group;
                for (int j = 0; j < selectedMuscelName.Count; j++)
                {
                    string muscel = selectedMuscelName[j].ToString();
                    for (int k = 0; k < muscel_Groups.Count; k++)
                    {
                        if (muscel.Equals(muscel_Groups[k].Name))
                        {
                            group = new Muscel_Group(muscel_Groups[k].Id, muscel);
                            Groups.Add(group);
                        }
                    }

                }
                Databas.AddExercise(exerciseName, Groups);

            }
            this.Close();
            personalize_Program.Show();
            List<string>listExersises = personalize_Program.GetExercises();
            personalize_Program.exerciseListBox.SelectedIndex = -1;
            personalize_Program.exerciseListBox.ItemsSource = listExersises;
            personalize_Program.exerciseListBox.Items.Refresh();


        }

        private void removeMuscelGroupButton_Click(object sender, RoutedEventArgs e)
        {
            effectedMuscelGroupListBox_ListBox_SelectionChanged();
        }

        private void effectedMuscelGroupListBox_ListBox_SelectionChanged()
        {
            string selectedItem = (string)effectedMuscelGroupListBox.SelectedItem;
            if (selectedItem != null)
            {
                for (int i = 0; i < Groups.Count; i++)
                {

                    if (selectedItem.Contains(Groups[i].Name))
                    {
                        Groups.RemoveAt(i);
                    }

                }
                string selectedExercise = selectedItem.ToString();
                if (selectedMuscelName.Contains(selectedExercise))
                {
                    selectedMuscelName.Remove(selectedExercise);
                }
                effectedMuscelGroupListBox.ItemsSource = selectedMuscelName;
                effectedMuscelGroupListBox.Items.Refresh();

                

            }
        }

        private void CanselButton_Click(object sender, RoutedEventArgs e)
        {
            this .Close();
            personalize_Program.Show();
        }
    }
}
