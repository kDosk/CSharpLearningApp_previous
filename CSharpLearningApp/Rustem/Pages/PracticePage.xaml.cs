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
	/// Логика взаимодействия для PracticePage.xaml
	/// </summary>
	public partial class PracticePage : Page
	{
		private List<PracticeModel> _practiceModels = new List<PracticeModel>();
		private List<PracticeModel> _listViewItems = new List<PracticeModel>();
		public PracticePage()
		{
			InitializeComponent();
			TestData();
		}
		private void TestData()
		{
			#region Test Questions
			_practiceModels.Add(new PracticeModel
			{
				ID = 1,
				Question = "1. Введите пропущенное слово: \"______ - оператор, который возвращает значение.\"",
				CorrectAnswer = "return"
			});
			_practiceModels.Add(new PracticeModel
			{
				ID = 2,
				Question = "2. Введите пропущенное слово:\"____ - тип, используемый для определения того, что метод не возвращает значение.\"",
				CorrectAnswer = "void"
			});
			_practiceModels.Add(new PracticeModel
			{
				ID = 3,
				Question = "3. Верное ли написание метода \"int GetValue(int a, int b) => a + b\"? Ответ: Верно | Неверно",
				CorrectAnswer = "Верно"
			});
			_practiceModels.Add(new PracticeModel
			{
				ID = 4,
				Question = "4. Верное ли написание метода \"string GetValue(int a, int b) => a + b\"? Ответ: Верно | Неверно",
				CorrectAnswer = "Неверно"
			});
			_practiceModels.Add(new PracticeModel
			{
				ID = 5,
				Question = "5. Верное ли написание метода \"void GetValue(int a, int b) => a + b\"? Ответ: Верно | Неверно",
				CorrectAnswer = "Неверно"
			});
			#endregion

			LViewTest.ItemsSource = _practiceModels;
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

			TestCalculate.CalculatePractice(_listViewItems, _practiceModels, "Оператор return");
			PageNavigationManager.ChangePage(new MainPage());
		}
	}
}
