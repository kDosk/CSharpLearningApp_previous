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
	/// Логика взаимодействия для TestPage2.xaml
	/// </summary>
	public partial class TestPage2 : Page
	{
		private List<TestModel> _testModels = new List<TestModel>();
		private List<TestModel> _listViewItems = new List<TestModel>();
		public TestPage2()
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
				Question = "1. Какая сокращенная версия данного метода?\n" +
						   "string GetValue()\n" +
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
						Value = "string GetValue() => return \"Hello World!\";"
					},
					new Answers
					{
						Id = 3,
						Value = "Никакая"
					},
				},
				CorrectAnswer = "string GetValue() => \"Hello World!\";"
			});

			_testModels.Add(new TestModel
			{
				ID = 2,
				Question = "2. Какая сокращенная версия данного метода?\n" +
						   "int GetValue(int x, int y)\n" +
						   "{\n" +
						   "\treturn x + y;\n" +
						   "}\n",
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "int GetValue(int x, int y) => x + y;"
					},
					new Answers
					{
						Id = 2,
						Value = "int GetValue(int x, int y) => return x + y;"
					},
					new Answers
					{
						Id = 3,
						Value = "Никакая"
					},
				},
				CorrectAnswer = "int GetValue(int x, int y) => x + y;"
			});

			_testModels.Add(new TestModel
			{
				ID = 3,
				Question = "3. Что будет возвращено при выполнении данного метода? \n" +
						   "string GetValue()\n" +
						   "{\n" +
						   "\tstring value = \"Hello World!\";\n" +
						   "\treturn value;\n" +
						   "\tvalue = \"Hello World!!!\";\n" +
						   "}\n",
				Answers = new List<Answers>()
				{
					new Answers
					{
						Id = 1,
						Value = "\"Hello World!\""
					},
					new Answers
					{
						Id = 2,
						Value = "\"Hello World!!!\""
					},
					new Answers
					{
						Id = 3,
						Value = "Ошибка"
					},
				},
				CorrectAnswer = "\"Hello World!\""
			});

			_testModels.Add(new TestModel
			{
				ID = 4,
				Question = "4. Что будет возвращено при выполнении данного кода? \n" +
						   "int GetValue(int x, int y) => x + y;\n" +
						   "\n" +
						   "GetValue();\n",
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
						Value = "Строка \"x\" + \"y\""
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
				ID = 5,
				Question = "5. Что будет возвращено при выполнении данного метода? \n" +
						   "int GetValue(int x, string y) => x + y;\n",
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
			#endregion

			LViewTest.ItemsSource = _testModels;
		}

		private void ButtonBack_Click(object sender, RoutedEventArgs e)
		{
            PageNavigationManager.GoBack();
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

			TestCalculate.Calculate(_listViewItems, _testModels, "Оператор return: Сокращенная версия методов с результатом");
		}
	}
}
