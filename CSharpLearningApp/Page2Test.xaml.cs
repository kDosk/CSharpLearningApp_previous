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
    /// Логика взаимодействия для Page2Test.xaml
    /// </summary>
    public partial class Page2Test : Page
    {
        public Page2Test()
        {
            InitializeComponent();
            TextBlock6.Text = "Цикл do...while - это...";
            TextBlock7.Text = "Цикл do...while, это цикл с...";
            TextBlock8.Text = "Цикл do...while выполняется...";
            TextBlock9.Text = "Цикл является бесконечным,если...";
            TextBlock10.Text = "Что сделать, чтобы не получить бесконечный цикл?";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {

            if (Radio6.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ!  Версия while с постпроверкой условия");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio7.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Цикл с постусловием");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio8.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! один или несколько раз");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio9.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! условие цикла никогда не станет = false");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio10.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! изменять параметр, проверяемый в условии");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
        }
    }
}
