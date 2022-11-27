using CSharpLearningApp.Classes;
using CSharpLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.PageByKamilya
{
	internal class PageData : PageDataBasic
	{
		private readonly ApplicationContext _db;
		public PageData(ApplicationContext db)
		{
			_db = db;
		}

		private void CreatePageData(string name)
		{
			if (!_db.Titles.ToList().Exists(p => p.Name == name))
			{
				var tempTitle = CreateTitle(name);

				var tempSubtitle1 = CreateSubtitle("Глава 1. Переменные", tempTitle);
				var tempTheory1 = CreateTheory("theory1", tempSubtitle1);
				var tempTestList1 = CreateTestList("Переменные: Тест", tempSubtitle1);

				var practice = CreatePractice("Задание1", "Ответ", tempSubtitle1);

				var tempAnswers1 = new string[] { "void", "const", "if" };
				var tempTestQuestion1 = CreateTestQuestion("Какое ключевое слово используется для определения констант?", tempAnswers1[1], tempTestList1, tempAnswers1);

				var tempAnswers2 = new string[] { "const string NAME = \"Tom\"; ", "const string NAME;", "NAME = \"Bob\";" };
				var tempTestQuestion2 = CreateTestQuestion("Какое ключевое слово используется для определения констант?", tempAnswers2[0], tempTestList1, tempAnswers2);
			}
		}
	}
}
