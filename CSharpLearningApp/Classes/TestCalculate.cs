using CSharpLearningApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CSharpLearningApp
{
	internal static class TestCalculate
	{
		/// <summary>
		/// Метод калькуляции правильных ответов теста с использованием элемента управления RadioButton
		/// </summary>
		/// <param name="listViewItems">Элементы ListView</param>
		/// <param name="testModels">Тестовый бланк</param>
		public static void Calculate(List<TestModel> listViewItems, List<TestModel> testModels, string title = null, string type = "type_1")
		{
			int correctAnswersCount = 0;
			int score = 0;

			for (int i = 0; i < listViewItems.Count; i++)
			{
				var currentAnswers = listViewItems[i].Answers;
				for (int j = 0; j < currentAnswers.Count; j++)
				{
					if (currentAnswers[j].IsCorrect == true && currentAnswers[j].Value == testModels[i].CorrectAnswer)
					{
						correctAnswersCount++;
						break;
					}
				}
			}

			double percent = 100f / listViewItems.Count  * correctAnswersCount;

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

			MessageService.ShowMessage($"Правильные ответы: {correctAnswersCount} из {listViewItems.Count}. Оценка: {score}");
			ShowResult(score, title, type);
		}

		/// <summary>
		/// Метод вывода результата на главное окно
		/// </summary>
		/// <param name="score">Оценка</param>
		/// <param name="title">Название темы</param>
		/// <param name="type">Тип задания: "type_1" - Тест, "type_2" - Практическое задание</param>
		public static void ShowResult(int score, string title, string type)
		{
			switch (type)
			{
				case "type_1":
					InfoStorage.SetInfo($"{UserModel.CurrentUser.Surname} {UserModel.CurrentUser.Name} завершил тестирование по теме \"{title}\", Оценка - {score}");
					break;
				case "type_2":
					InfoStorage.SetInfo($"{UserModel.CurrentUser.Surname} {UserModel.CurrentUser.Name} завершил практическое задание по теме \"{title}\", Оценка - {score}");
					break;
				default:
					break;
			}
		}

		public static void CalculatePractice(List<PracticeModel> listViewItems, List<PracticeModel> practiceModels, string title = null, string type = "type_2")
		{
			int score = 0;
			int correctAnswersCount = 0;
			for (int i = 0; i < listViewItems.Count; i++)
			{
				if (listViewItems[i].Answer.ToLower() == practiceModels[i].CorrectAnswer.ToLower())
				{
					correctAnswersCount++;
				}
			}

			double percent = 100f / listViewItems.Count * correctAnswersCount;

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

			MessageService.ShowMessage($"Правильные ответы: {correctAnswersCount} из {listViewItems.Count}. Оценка: {score}");
			ShowResult(score, title, type);
		}
	}
}
