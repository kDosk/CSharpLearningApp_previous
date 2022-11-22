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
    /// Логика взаимодействия для Page3Test.xaml
    /// </summary>
    public partial class Page3Test : Page
    {
        public Page3Test()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Radio11.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Действия выполняются один раз до выполнения цикла.");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio12.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Условие, при котором будет выполняться цикл. ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio13.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Действия выполняются после завершения блока цикла");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio14.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Действия выполняются после завершения блока цикла");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio15.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! Действия выполняются после завершения блока цикла");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
        }
    }
}
