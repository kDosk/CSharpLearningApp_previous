using CSharpLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData
{
	internal interface IPageData
	{
		Title CreateTitle(string title, List<Subtitle> subtitles);
		Subtitle CreateSubtitle(string subtitle, Title title, TestList testList);
		Theory CreateTheory(string theoryContent, Subtitle subtitle);
		Practice CreatePractice(string practiceTask, string correctAnsewer, Subtitle subtitle);
		TestList CreateTestList(string title, Subtitle subtitle, List<TestQuestion> testsQuestions);
		TestQuestion CreateTestQuestion(string question, List<Answer> answers, Answer correctAnswer, TestList testList);
		Answer CreateAnswer(string answer, TestQuestion testQuestion);
		void LoadData();
	}
}
