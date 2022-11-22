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

namespace CSharpLearningApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PracticePage.xaml
    /// </summary>
    public partial class PracticePage : Page
    {
		private List<PracticeModel> _testModels = new List<PracticeModel>();
		private List<PracticeModel> _listViewItems = new List<PracticeModel>();
		public PracticePage()
		{
			InitializeComponent();
			TestData();
		}
		private void TestData()
		{
			#region Test Questions
			_testModels.Add(new PracticeModel
			{
				ID = 1,
				Question = "______ - оператор, который возвращает значение.",
				CorrectAnswer = "return"
			});
			_testModels.Add(new PracticeModel
			{
				ID = 2,
				Question = "____ - тип, используемый для определения того, что метод не возвращает значение.",
				CorrectAnswer = "void"
			});
			_testModels.Add(new PracticeModel
			{
				ID = 3,
				Question = "Верное ли написание метода \"int GetValue(int a, int b) => a + b\"? Ответ: Верно | Неверно",
				CorrectAnswer = "Верно"
			});
			_testModels.Add(new PracticeModel
			{
				ID = 4,
				Question = "Верное ли написание метода \"string GetValue(int a, int b) => a + b\"? Ответ: Верно | Неверно",
				CorrectAnswer = "Неверно"
			});
			_testModels.Add(new PracticeModel
			{
				ID = 5,
				Question = "Верное ли написание метода \"void GetValue(int a, int b) => a + b\"? Ответ: Верно | Неверно",
				CorrectAnswer = "Неверно"
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
					_listViewItems.Add(item as PracticeModel);
				}
			}

			int correctAnswersCount = 0;
			for (int i = 0; i < _listViewItems.Count; i++)
			{
				if (_listViewItems[i].Answer.ToLower() == _testModels[i].CorrectAnswer.ToLower())
				{
					correctAnswersCount++;
				}
			}

			MessageService.ShowMessage($"Правильных ответов: {correctAnswersCount} из {_listViewItems.Count}");
		}
	}

	public class PracticeModel
	{
		public int ID { get; set; }
		public string Question { get; set; }
		public string CorrectAnswer { get; set; }
		public string Answer { get; set; } = string.Empty;
	}
}
