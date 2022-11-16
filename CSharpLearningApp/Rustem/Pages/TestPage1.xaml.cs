using CSharpLearningApp.Rustem.Models;
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

namespace CSharpLearningApp.Rustem.Pages
{
	/// <summary>
	/// Логика взаимодействия для TestPage1.xaml
	/// </summary>
	public partial class TestPage1 : Page
	{
		private List<TestModel> _testModels = new List<TestModel>();
		public TestPage1()
		{
			InitializeComponent();
			TestData();
		}
		private void TestData()
		{
			#region Test Questions
			_testModels.Add(new TestModel
			{
				ID = 1,
				Question = "Какой оператор используется в методе для возврата значения?",
				//Answers = new string[] {"return", "void", "async"},
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "return"
					},
					new Answers
					{
						Id = 2,
						Value = "void"
					},
					new Answers
					{
						Id = 3,
						Value = "async"
					},
				},
				CorrectAnswer = "return"
			});

			_testModels.Add(new TestModel
			{
				ID = 2,
				Question = "Какой тип используется в методе, который НЕ возвращает значение?",
				//Answers = new string[] { "return", "void", "async" },
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "return"
					},
					new Answers
					{
						Id = 2,
						Value = "void"
					},
					new Answers
					{
						Id = 3,
						Value = "async"
					},
				},
				CorrectAnswer = "void"
			});

			_testModels.Add(new TestModel
			{
				ID = 3,
				Question = "Что будет возвращено при выполнении данного метода? \n" +
						   "string GetValue()\n" +
						   "{\n" +
						   "\treturn 3;\n" +
						   "}\n",
				//Answers = new string[] { "Число 3", "Строка \"3\"", "Ошибка" },
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "Число 3"
					},
					new Answers
					{
						Id = 2,
						Value = "Строка \"3\""
					},
					new Answers
					{
						Id = 3,
						Value = "Ошибка"
					},
				},
				CorrectAnswer = "Ошибка"
			});

			_testModels.Add(new TestModel
			{
				ID = 4,
				Question = "Что будет возвращено при выполнении данного метода? \n" +
						   "string GetValue()\n" +
						   "{\n" +
						   "\tint a = 5;\n" +
						   "\tint b = 0;\n" +
						   "\tfor(int i = 0; i == a; i++);\n" +
						   "\t{\n" +
						   "\t\tb += i;\n" +
						   "\t}\n" +
						   "\treturn b.toString();\n" +
						   "}\n",
				//Answers = new string[] { "Строка \"5\"", "Число 5", "Ошибка" },
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "Строка \"5\""
					},
					new Answers
					{
						Id = 2,
						Value = "Число 5"
					},
					new Answers
					{
						Id = 3,
						Value = "Ошибка"
					},
				},
				CorrectAnswer = "Строка \"5\""
			});

			_testModels.Add(new TestModel
			{
				ID = 5,
				Question = "Что будет возвращено при выполнении данного метода? \n" +
						   "void GetValue()\n" +
						   "{\n" +
						   "\tConsole.WriteLine(\"Hello World!\")\n" +
						   "}\n",
				//Answers = new string[] { "Строка \"Hello World!\"", "Ошибка", "Ничего" },
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "Строка \"Hello World!\""
					},
					new Answers
					{
						Id = 2,
						Value = "Ошибка"
					},
					new Answers
					{
						Id = 3,
						Value = "Ничего"
					},
				},
				CorrectAnswer = "Ничего"
			}); 
			#endregion

			LViewTest.ItemsSource = _testModels;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			NavigatonManager.GoBack();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			int correctAnswersCount = 0;
			var currentListItems = LViewTest.Items;
			for (int i = 0; i < currentListItems.Count; i++)
			{
				var currentAnswers = (currentListItems[i] as TestModel).Answers;
				for (int j = 0; j < currentAnswers.Count; j++)
				{
					if (currentAnswers[j].IsCorrect == true && currentAnswers[j].Value == _testModels[i].CorrectAnswer)
					{
						correctAnswersCount++;
						break;
					}
				}
			}
		}
	}
}
