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

namespace CSharpLearningApp.Galimova
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
			//if (Radio11.IsChecked == true)
			//{
			//    MessageBox.Show("Правильный ответ! Выйти из цикла, из оператора выбора, из блока");
			//}
			//else
			//{
			//    MessageBox.Show("Неправильный ответ!");
			//}
			//if (Radio12.IsChecked == true)
			//{
			//    MessageBox.Show("Правильный ответ! для прерывания текущей итерации");
			//}
			//else
			//{
			//    MessageBox.Show("Неправильный ответ!");
			//}
			//if (Radio13.IsChecked == true)
			//{
			//    MessageBox.Show("Правильный ответ! нужно перейти к выполнению следующей итерации");
			//}
			//else
			//{
			//    MessageBox.Show("Неправильный ответ!");
			//}
			//if (Radio14.IsChecked == true)
			//{
			//    MessageBox.Show("Правильный ответ! запускает новую итерацию цикла");
			//}
			//else
			//{
			//    MessageBox.Show("Неправильный ответ!");
			//}
			//if (Radio15.IsChecked == true)
			//{
			//    MessageBox.Show("Правильный ответ! организованные в теле другого цикла");
			//}
			//else
			//{
			//    MessageBox.Show("Неправильный ответ!");
			//}

			int correctAnswersCount = 0;
			int score = 0;

			if (Radio11.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! Выйти из цикла, из оператора выбора, из блока");
				correctAnswersCount++;
			}
			if (Radio12.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! для прерывания текущей итерации");
				correctAnswersCount++;
			}
			if (Radio13.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! нужно перейти к выполнению следующей итерации");
				correctAnswersCount++;
			}
			if (Radio14.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! запускает новую итерацию цикла");
				correctAnswersCount++;
			}
			if (Radio15.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! организованные в теле другого цикла");
				correctAnswersCount++;
			}

			double percent = 100f / 5 * correctAnswersCount;

			if (percent < 40)
			{
				score = 2;
			}
			else if (percent >= 40 && percent < 60)
			{
				score = 3;
			}
			else if (percent >= 60 && percent < 70)
			{
				score = 4;
			}
			else
			{
				score = 5;
			}

			MessageService.ShowMessage($"Правильных ответов: {correctAnswersCount} из 5. Оценка: {score}.");
			TestCalculate.ShowResult(score, "Циклы: Команды continue и break", "type_1");
			NavigationService.Navigate(new MainPage());
		}
    }
}
