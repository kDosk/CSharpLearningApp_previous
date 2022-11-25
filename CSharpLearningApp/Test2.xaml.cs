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
    /// Логика взаимодействия для Test2.xaml
    /// </summary>
    public partial class Test2 : Page
    {
        public Test2()
        {
            InitializeComponent();
            TextBlock6.Text = "Что вызывает PrintHelloWorld?";
            TextBlock7.Text = "Вызов метода-это?";
            TextBlock8.Text = "Строка начинающаяся с двух символов слеш называется?";
            TextBlock9.Text = "Что применяет Cube";
            TextBlock10.Text = "В каких местах можно встретить вызов метода?";

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new mainpage());
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

