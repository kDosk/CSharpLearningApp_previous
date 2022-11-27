using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.Models.PageModels.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData
{
    internal class PageDataBasic
	{
		protected Answer CreateAnswer(string answer, TestQuestion testQuestion)
		{
			return new Answer
			{
				Value = answer,
				TestQuestion = testQuestion
			};
		}

		protected TestQuestion CreateTestQuestion(string question, string correctAnswer, TestList testList, string[] answers)
		{
			List<Answer> answerList = new List<Answer>();
			
			var testQuestion = new TestQuestion
			{
				Question = question,
				TestList = testList,
				CorrectAnswer = correctAnswer
			};

			foreach (var item in answers)
			{
				answerList.Add(new Answer
				{
					Value = item,
					TestQuestion = testQuestion
				});
			}

			testQuestion.Answers = answerList;

			return testQuestion;
		}

		protected TestList CreateTestList(string title, Subtitle subtitle)
		{
			return new TestList
			{
				Title = title,
				Subtitle = subtitle
			};
		}

		protected Practice CreatePractice(string practiceTask, string correctAnsewer, Subtitle subtitle)
		{
			return new Practice
			{
				Task = practiceTask,
				CorrectAnswer = correctAnsewer,
				Subtitle = subtitle
			};
		}

		protected Theory CreateTheory(string theoryContent, Subtitle subtitle)
		{
			return new Theory
			{
				TheoryContent = theoryContent,
				Subtitle = subtitle
			};
		}

		protected Subtitle CreateSubtitle(string subtitle, Title title)
		{
			return new Subtitle
			{
				Name = subtitle,
				Title = title
			};
		}

		protected Title CreateTitle(string title)
		{
			return new Title
			{
				Name = title
			};
		}
	}
}
