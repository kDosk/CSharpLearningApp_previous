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

namespace CSharpLearningApp.TagirBranch
{
    /// <summary>
    /// Логика взаимодействия для ValidationLogPage.xaml
    /// </summary>
    public partial class ValidationLogPage : Page
    {
        public ValidationLogPage()
        {
            InitializeComponent();
            TextBlock1.Text = "Операция логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из операндов возвращает true.";
            TextBlock2.Text = "Операция логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true.";
            TextBlock3.Text = "Операция логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true.";
            TextBlock5.Text = "Операция логического отрицания. Производится над одним операндом и возвращает true, если операнд равен false. Если операнд равен true, то операция возвращает false:";
            TextBlock6.Text = "Операция исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio2.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio3.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio5.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio6.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio1.IsChecked == true && Radio2.IsChecked == true && Radio3.IsChecked == true && Radio5.IsChecked == true && Radio6.IsChecked == true)
            {
                NavigationService.Navigate(new PracticeLogPage());
            }
            if (Radio1.IsChecked == false || Radio2.IsChecked == false || Radio3.IsChecked == false || Radio5.IsChecked == false || Radio6.IsChecked == false)
            {
                NavigationService.Navigate(new TheoryLogPage());
            }
        }
    }
}
