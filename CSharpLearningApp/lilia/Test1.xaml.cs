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

namespace CSharpLearningApp.lilia
{
    /// <summary>
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Page
    {
        public Test1()
        {
            InitializeComponent();
            TextBlock1.Text = "Как обозначается базовая операция присваивания?";
            TextBlock2.Text = "Как обозначается дизъюнкция?";
            TextBlock3.Text = "Как обозначается присваивание после деления?";
            TextBlock4.Text = "Какое обозначение имеет присваивание после операции исключающего ИЛИ?";
            TextBlock5.Text = "Сколько операций присваивания существует?";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            int correctAnswersCount = 0;
            int score = 0;
            if (Radio1.IsChecked == true)
            {
                correctAnswersCount++;

			}
            if (Radio2.IsChecked == true)
            {
				correctAnswersCount++;
			}
            if (Radio3.IsChecked == true)
            {
				correctAnswersCount++;
			}
            if (Radio4.IsChecked == true)
            {
				correctAnswersCount++;
			}
            if (Radio5.IsChecked == true)
            {
				correctAnswersCount++;
			}

			double percent = 100f / 5f * correctAnswersCount;

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

            MessageService.ShowMessage($"Правильные ответы: {correctAnswersCount} из 5. Оценка: {score}.");
            TestCalculate.ShowResult(score, "Операции присваивание: Базовые операции", "type_1");
			NavigationService.Navigate(new MainPage());
		}
    }
}
