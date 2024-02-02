using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TräningsProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            UserIdBox.Text = "Admin";
            PasswordTextBox.Text = "a";
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            User user = CheckLogIn();
            if (user == null)
            {
                MessageBox.Show("Invali UserId / Password");
                PasswordTextBox.Clear();
            }
            else
            {
                UserIdBox.Clear();
                PasswordTextBox.Clear();
                this.Hide();
                Choose_Program choose_Program = new Choose_Program(user);
                choose_Program.Show();
                choose_Program.usernameTextBlock.Text = user.Name;
                
            }
        }

        public User CheckLogIn ()
        {
            Databas databas = new Databas();
           List<User> users = databas.GetAllUsers();

            
            string userName = UserIdBox.Text;
            string password = PasswordTextBox.Text;

            foreach (User user in users)
            {
                if (userName == user.Name && password == user.Password)
                {
                    return user;
                    break;
                }
            }
            return null;
        }

        private void registerNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterNewUser registerNewUser = new RegisterNewUser();    
            registerNewUser.Show();
            this.Hide();
        }
    }
}
