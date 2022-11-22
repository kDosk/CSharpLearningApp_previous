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

namespace CSharpLearningApp
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            if (UserModel.CurrentUser == null)
            {
                UserInfoGrid.Visibility = Visibility.Collapsed;
                AuthGrid.Visibility = Visibility.Visible;
                ShowSignInElement();
            }
            else
            {
                UserInfoGrid.Visibility = Visibility.Visible;
                AuthGrid.Visibility = Visibility.Collapsed;

                TBoxUser.Text = $"{UserModel.CurrentUser.Surname} {UserModel.CurrentUser.Name}";
            }
        }

        private void SignInButton_Checked(object sender, RoutedEventArgs e)
        {
            ShowSignInElement();
        }

        private void ShowSignInElement()
        {
            SignInButton.IsChecked = true;

            TBoxSignInLogin.Text = String.Empty;
            TBoxSignInPass.Text = String.Empty;

            gridSignIn.Visibility = Visibility.Visible;
            gridSignUp.Visibility = Visibility.Collapsed;
        }

        private void SignUpButton_Checked(object sender, RoutedEventArgs e)
        {
            ShowSignUpElement();
        }

        private void ShowSignUpElement()
        {
            SignUpButton.IsChecked = true;

            TBoxSignUpSurname.Text = string.Empty;
            TBoxSignUpName.Text = string.Empty;
            TBoxSignUpLogin.Text = string.Empty;
            TBoxSignUpPass.Text = string.Empty;
            TBoxSignUpPassConfirm.Text = string.Empty;

            gridSignUp.Visibility = Visibility.Visible;
            gridSignIn.Visibility = Visibility.Collapsed;
        }

        private void Authorization(string login, string pass)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(pass))
            {
                var user = UserModel.SearchUser(login, pass);
                if (user != null)
                {
                    UserModel.CurrentUser = user;

                    UserInfoGrid.Visibility = Visibility.Visible;
                    AuthGrid.Visibility = Visibility.Collapsed;
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

        private void Registration(string surname, string name, string login, string pass, string confirmPass)
        {
            if (!string.IsNullOrEmpty(surname) &&
                !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(login) &&
                !string.IsNullOrEmpty(pass) &&
                !string.IsNullOrEmpty(confirmPass))
            {
                if (pass == confirmPass)
                {
                    UserModel.AddUser(name, login, pass, surname);
                    UserModel.CurrentUser = UserModel.SearchUser(login, pass);

                    UserInfoGrid.Visibility = Visibility.Visible;
                    AuthGrid.Visibility = Visibility.Collapsed;
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
            TBoxUser.Text = $"{UserModel.CurrentUser.Surname} {UserModel.CurrentUser.Name}";
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Registration(TBoxSignUpSurname.Text, TBoxSignUpName.Text, TBoxSignUpLogin.Text, TBoxSignUpPass.Text, TBoxSignUpPassConfirm.Text);
            TBoxUser.Text = $"{UserModel.CurrentUser.Surname} {UserModel.CurrentUser.Name}";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            UserModel.CurrentUser = null;
            UserInfoGrid.Visibility = Visibility.Collapsed;
            AuthGrid.Visibility = Visibility.Visible;
            ShowSignInElement();
        }
    }
}
