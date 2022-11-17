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
    /// Логика взаимодействия для ValidationSravPage.xaml
    /// </summary>
    public partial class ValidationSravPage : Page
    {
        public ValidationSravPage()
        {
            InitializeComponent();
            TextBlock1.Text = "Какая операция сравнивает два операнда на равенство, если они равны то возвращает true?";
            TextBlock2.Text = "Какая операция сравнивает два операнда на равенство, если они не равны то возвращает true?"; 
            TextBlock4.Text = "Какая операция сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false?";
            TextBlock5.Text = "Какая операция сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. Иначе возвращает false?";
            TextBlock6.Text = "Какая операция сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false?";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! (==)");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio2.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! (!=)");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio4.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! (>)");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio5.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! (Нет ответа правильного)");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio6.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! (>=)");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio1.IsChecked == true && Radio2.IsChecked == true && Radio4.IsChecked == true && Radio5.IsChecked == true && Radio6.IsChecked == true)
            {
                NavigationService.Navigate(new PracticeSravPage());
            }
            if (Radio1.IsChecked == false || Radio2.IsChecked == false || Radio4.IsChecked == false || Radio5.IsChecked == false || Radio6.IsChecked == false)
            {
                NavigationService.Navigate(new TheorySravpage());
            }
        }
    }
}
