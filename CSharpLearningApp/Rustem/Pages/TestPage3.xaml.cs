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
	/// Логика взаимодействия для TestPage3.xaml
	/// </summary>
	public partial class TestPage3 : Page
	{
		private List<TestModel> _testModels = new List<TestModel>();
		private List<TestModel> _listViewItems = new List<TestModel>();
		public TestPage3()
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
				Question = "Что вернется при выполнении данного метода?\n" +
						   "void GetValue()\n" +
						   "{\n" +
						   "\treturn \"Hello World!\";\n" +
						   "}\n",
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "string GetValue() => \"Hello World!\";"
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
				CorrectAnswer = "Ошибка"
			});

			_testModels.Add(new TestModel
			{
				ID = 2,
				Question = "Что вернется при выполнении данного кода?\n" +
						   "string GetValue(int a, int b)\n" +
						   "{\n" +
						   "\tif (a > b)\n" +
						   "\t{\n" +
						   "\t\treturn \"a больше b\"\n" +
						   "\t}\n" +
						   "\telse if (a < b)\n" +
						   "\t{\n" +
						   "\t\treturn \"b больше a\"\n" +
						   "\t}\n" +
						   "}\n" +
						   "GetValue(1, 0)\n",
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "\"a больше b\""
					},
					new Answers
					{
						Id = 2,
						Value = "\"b больше a\""
					},
					new Answers
					{
						Id = 3,
						Value = "Ничего"
					},
				},
				CorrectAnswer = "\"a больше b\""
			});

			_testModels.Add(new TestModel
			{
				ID = 3,
				Question = "Что будет возвращено при выполнении данного метода? \n" +
						   "void GetValue(int x, int y) => x + y\n",
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "Сумма \"x\" и \"y\""
					},
					new Answers
					{
						Id = 2,
						Value = "Ничего"
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
				Question = "Для чего используется тип void?\n",
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "Для возврата переменной"
					},
					new Answers
					{
						Id = 2,
						Value = "Для определения того, что метод не возвращает значение"
					},
					new Answers
					{
						Id = 3,
						Value = "Для проверки метода"
					},
				},
				CorrectAnswer = "Для определения того, что метод не возвращает значение"
			});

			_testModels.Add(new TestModel
			{
				ID = 5,
				Question = "Для чего используется оператор return void?\n",
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "Для определения того, что метод не возвращает значение"
					},
					new Answers
					{
						Id = 2,
						Value = "Для завершения выполнения метода"
					},
					new Answers
					{
						Id = 3,
						Value = "Для перехода на другое окно приложения"
					},
				},
				CorrectAnswer = "Для завершения выполнения метода"
			});
			#endregion

			LViewTest.ItemsSource = _testModels;
		}

		private void ButtonBack_Click(object sender, RoutedEventArgs e)
		{
			NavigatonManager.GoBack();
		}

		private void ButtonCompleteTest_Click(object sender, RoutedEventArgs e)
		{

			//Заполнение элемента List<TestModel>
			if (_listViewItems.Count == 0)
			{
				foreach (var item in LViewTest.Items)
				{
					_listViewItems.Add(item as TestModel);
				}
			}

			TestCalculate.Calculate(_listViewItems, _testModels);
		}
	}
}
