﻿using System;
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
		}
	}
}
