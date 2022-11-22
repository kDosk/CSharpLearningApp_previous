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

namespace CSharpLearningApp
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            SignInButton.IsChecked = true;
        }

        private void SignInButton_Checked(object sender, RoutedEventArgs e)
        {
            gridSignIn.Visibility = Visibility.Visible;
            gridSignUp.Visibility = Visibility.Collapsed;
        }

        private void SignUpButton_Checked(object sender, RoutedEventArgs e)
        {
            gridSignUp.Visibility = Visibility.Visible;
            gridSignIn.Visibility = Visibility.Collapsed;
        }

        private void Authorization(string name, string pass)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(pass))
            {
                var user = UserModel.GetUser(name, pass);
                if (user != null)
                {
                    UserStorage.CurrentUser = user;
                    DialogResult = true;
                }
                else
                {
                    MessageService.ShowError("Пользователь не найден.");
                }
            }
            else
            {
                MessageService.ShowError("Проверьте введенные данные.");
            }
        }

        private void Registration(string surname, string name, string pass, string confirmPass)
        {
            if (!string.IsNullOrEmpty(surname) &&
                !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(pass) &&
                !string.IsNullOrEmpty(confirmPass))
            {
                if (pass == confirmPass)
                {
                    UserModel.AddUser(name, pass, surname);
                    UserStorage.CurrentUser = UserModel.GetUser(name, pass);
                    DialogResult = true;
                }
                else
                {
                    MessageService.ShowError("Пароли не совпадают.");
                }
            }
            else
            {
                MessageService.ShowError("Проверьте введенные данные.");
            }
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Authorization(TBoxSignInLogin.Text, TBoxSignInPass.Text);
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Registration(TBoxSignUpSurname.Text, TBoxSignUpName.Text, TBoxSignUpPass.Text, TBoxSignUpPassConfirm.Text);
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
