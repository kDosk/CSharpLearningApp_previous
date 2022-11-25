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
    /// Логика взаимодействия для Test3.xaml
    /// </summary>
    public partial class Test3 : Page
    {
        public Test3()
        {
            InitializeComponent();
            TextBlock11.Text = "Формальные параметры-это переменные...";
            TextBlock12.Text = "Какой оператор используется в теле метода?";
            TextBlock13.Text = "Что делает тип void?";
            TextBlock14.Text = "Что имеет метод GetSum?";
            TextBlock15.Text = "Return-это...";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new mainpage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Radio11.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Выйти из цикла, из оператора выбора, из блока");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio12.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! для прерывания текущей итерации");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio13.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! нужно перейти к выполнению следующей итерации");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio14.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! запускает новую итерацию цикла");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio15.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! организованные в теле другого цикла");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
        }
    }
}
