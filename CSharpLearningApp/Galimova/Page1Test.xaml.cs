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
    /// Логика взаимодействия для Page1Test.xaml
    /// </summary>
    public partial class Page1Test : Page
    {
        public Page1Test()
        {
            InitializeComponent();
            TextBlock1.Text = "Выберите первую часть объявления цикла for:";
            TextBlock2.Text = "Выберите вторую часть объявления цикла for:";
            TextBlock3.Text = "Выберите третью часть объявления цикла for:";
            TextBlock4.Text = "Что такое итерация в цикле for?";
            TextBlock5.Text = "Для чего предназначен цикл foreach?";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
			int correctAnswersCount = 0;
			int score = 0;

			//if (Radio1.IsChecked == true)
   //         {
   //             MessageBox.Show("Правильный ответ! Действия выполняются один раз до выполнения цикла.");
   //         }
   //         else
   //         {
   //             MessageBox.Show("Неправильный ответ!");
   //         }
   //         if (Radio2.IsChecked == true)
   //         {
   //             MessageBox.Show("Правильный ответ! Условие, при котором будет выполняться цикл. ");
   //         }
   //         else
   //         {
   //             MessageBox.Show("Неправильный ответ!");
   //         }
   //         if (Radio3.IsChecked == true)
   //         {
   //             MessageBox.Show("Правильный ответ! Действия выполняются после завершения блока цикла");
   //         }
   //         else
   //         {
   //             MessageBox.Show("Неправильный ответ!");
   //         }
   //         if (Radio4.IsChecked == true)
   //         {
   //             MessageBox.Show("Правильный ответ! Однократное выполнение блока цикла");
   //         }
   //         else
   //         {
   //             MessageBox.Show("Неправильный ответ!");
   //         }
   //         if (Radio5.IsChecked == true)
   //         {
   //             MessageBox.Show("Правильный ответ! Для перебора набора или коллекции элементов");
   //         }
   //         else 
   //         {
   //             MessageBox.Show("Неправильный ответ!");
   //         }

			if (Radio1.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! Действия выполняются один раз до выполнения цикла.");
				correctAnswersCount++;
			}
			if (Radio2.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! Условие, при котором будет выполняться цикл. ");
				correctAnswersCount++;
			}
			if (Radio3.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! Действия выполняются после завершения блока цикла");
				correctAnswersCount++;
			}
			if (Radio4.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! Однократное выполнение блока цикла");
				correctAnswersCount++;
			}
			if (Radio5.IsChecked == true)
			{
				MessageBox.Show("Правильный ответ! Для перебора набора или коллекции элементов");
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
			TestCalculate.ShowResult(score, "Циклы: Циклы for, foreach", "type_1");
			NavigationService.Navigate(new MainPage());
		}
    }
}
