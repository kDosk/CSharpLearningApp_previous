using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.PageByKamilya
{
    internal class PageCreateData : PageDataBasic
	{
		private readonly ApplicationContext _db;
		public PageCreateData(ApplicationContext db)
		{
			_db = db;
			CreatePageData("123");
		}

		private void CreatePageData(string name)
		{
			if (!_db.Titles.ToList().Exists(p => p.Name == name))
			{
				var tempTitle = CreateTitle(name);

				var tempSubtitle1 = CreateSubtitle("Глава 1. Переменные", tempTitle);
				var tempTheory1 = CreateTheory("theory1", tempSubtitle1);
				var tempTestList1 = CreateTestList("Переменные: Тест", tempSubtitle1);

				var tempPractice1 = CreatePractice("Задание1", "Ответ", tempSubtitle1);

				var tempAnswers1 = new string[] { "void", "const", "if" };
				var tempTestQuestion1 = CreateTestQuestion("Какое ключевое слово используется для определения констант?", tempAnswers1[1], tempTestList1, tempAnswers1);

				var tempAnswers2 = new string[] { "const string NAME = \"Tom\"; ", "const string NAME;", "NAME = \"Bob\";" };
				var tempTestQuestion2 = CreateTestQuestion("Какое ключевое слово используется для определения констант?", tempAnswers2[0], tempTestList1, tempAnswers2);

				var tempTestQuestionsList = new List<TestQuestion>() { tempTestQuestion1, tempTestQuestion2 };
				tempTestList1.TestQuestions = tempTestQuestionsList;

				tempSubtitle1.Theory = tempTheory1;
				tempSubtitle1.TestList = tempTestList1;
				tempSubtitle1.Practice = tempPractice1;


			}
		}
	}
}
