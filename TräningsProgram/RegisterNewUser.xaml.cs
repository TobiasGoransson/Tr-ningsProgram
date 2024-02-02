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
    /// Interaction logic for RegisterNewUser.xaml
    /// </summary>
    public partial class RegisterNewUser : Window
    {
        Databas Databas = new Databas();
        MainWindow MainWindow =new MainWindow();
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private void backToLogInButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow.Show();
        }
        public User EnterUserInfo()
        {

            string UserName = registerUserNameTextBox.Text;
            string Password = registerPasswordTextBox.Text;


            User user = new User(UserName, Password);
            return user;

        }
        private bool CheckPassword()
        {
            if (registerPasswordTextBox.Text != registerVerifyPasswordTextBox.Text)
            {

                MessageBox.Show("Your Passwords doesnt match");
                return false;
            }
            return true;
        }
        public bool CheckuserName()
        {
            List<User> users=Databas.GetAllUsers();
            foreach (User user in users)
            {
                if(registerUserNameTextBox.Text == user.Name)
                {
                    MessageBox.Show("This user already exists");
                    return false;
                }
                
            }
            return true;
        }

        private void saveUserButton_Click(object sender, RoutedEventArgs e)
        {
            bool UserName = CheckuserName();
            bool Password = CheckPassword();

            if (UserName == true && Password == true)
            {
                this.Close();
                MainWindow.Show();
                string newUser = registerUserNameTextBox.Text;
                string newPassword = registerPasswordTextBox.Text;
                Databas.AddUser(newUser, newPassword);
            }
            
        }
    }
}
