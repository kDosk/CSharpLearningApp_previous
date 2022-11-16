using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace CSharpLearningApp.TagirBranch
{
    /// <summary>
    /// Логика взаимодействия для ValidationPage.xaml
    /// </summary>
    public partial class ValidationPage : Page
    {
        public ValidationPage()
        {
            InitializeComponent();
            TextBlock1.Text = "Какой тип данных возвращает логические операции?";
            TextBlock2.Text = "Какие значение принимает bool?";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (Radiobool.IsChecked==true)
            {
               MessageBox.Show("Правильный ответ! Bool!");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (RadioOba.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Оба!");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radiobool.IsChecked == true && RadioOba.IsChecked == true)
            {
                NavigationService.Navigate(new PracticePage());
            }
            if (Radiobool.IsChecked == false || RadioOba.IsChecked == false)
            {
                NavigationService.Navigate(new TheoryPage());
            }


        }
    }
}
