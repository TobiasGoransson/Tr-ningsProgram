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
using System.Windows.Shapes;

namespace TräningsProgram
{
    /// <summary>
    /// Interaction logic for RunWorkout.xaml
    /// </summary>
    public partial class RunWorkout : Window
    {
        public User User;
        public RunWorkout(User user)
        {
            InitializeComponent();
            User = user;
            exerciseListBox.AddHandler(ScrollViewer.ScrollChangedEvent, new ScrollChangedEventHandler(ExerciseListBox_ScrollChanged));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Choose_Program choose_Program = new Choose_Program(User);
            choose_Program.Show();
        }

        private void ExerciseListBox_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (exerciseListBox.SelectedIndex >= 0 && exerciseListBox.SelectedIndex < durationListBox.Items.Count)
            {
                
                var exerciseScrollViewer = GetScrollViewer(exerciseListBox);

                durationListBox.ScrollIntoView(durationListBox.Items[exerciseListBox.SelectedIndex]);
            }
        }

            private ScrollViewer GetScrollViewer(ListBox listBox)
        {
            var border = VisualTreeHelper.GetChild(listBox, 0) as Border;
            return border.Child as ScrollViewer;
        }

       
    }
}
