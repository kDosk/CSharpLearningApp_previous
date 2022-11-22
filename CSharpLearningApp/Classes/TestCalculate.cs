using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp
{
	internal static class TestCalculate
	{
		/// <summary>
		/// Метод калькуляции правильных ответов теста с использованием элемента управления RadioButton
		/// </summary>
		/// <param name="listViewItems">Элементы ListView</param>
		/// <param name="testModels">Тестовый бланк</param>
		public static void Calculate(List<TestModel> listViewItems, List<TestModel> testModels)
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

			var percent = listViewItems.Count / 100 * correctAnswersCount;

			if (percent < 50)
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

			MessageService.ShowMessage($"Правильные ответы: {correctAnswersCount} из {listViewItems.Count}");
			InfoStorage.SetInfo($"{UserModel.CurrentUser.Surname} {UserModel.CurrentUser.Name} завершил тестирование по теме \"Оператор return\", Оценка - {score}");
		}
	}
}
