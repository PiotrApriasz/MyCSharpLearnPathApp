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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ApplicationCore;
using DataAccess;

namespace MyCSharpLearnPathWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LoginTextBox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                if (RegisterService.IsLoginSameAsRegisteredBefore(LoginTextBox.Text))
                    MessageBox.Show("Login already exist!", "Register");
                else if (LoginTextBox.Text.Length < 3)
                    MessageBox.Show("Login must have more than 2 chars!", "Register");
                else if (PasswordBox.Password.Length < 3)
                    MessageBox.Show("Password must have more than 2 chars!", "Register");
                else
                {
                    var user = new User()
                    {
                        Login = LoginTextBox.Text,
                        Password = PasswordBox.Password
                    };

                    RegisterService.RegisterInXml(user);

                    MessageBox.Show("User have been registered succesfully!", "Register");
                }
            }
            else
            {
                MessageBox.Show("Incorrect inputs!", "Register");
            }
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LoginTextBox.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                var signedIn = LoggingService.LoginXml(LoginTextBox.Text, PasswordBox.Password);

                if (signedIn)
                {
                    var user = new User() {Login = LoginTextBox.Text, Password = PasswordBox.Password};
                    MessageBox.Show("Signed in correctly!", "Login");
                }
                else MessageBox.Show("Incorrect login or password!", "Login");
            }
            else MessageBox.Show("Incorrect inputs!", "Login");
        }
    }
}