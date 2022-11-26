using CSharpLearningApp.Classes;
using CSharpLearningApp.Models;
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

namespace CSharpLearningApp.Templates
{
	/// <summary>
	/// Логика взаимодействия для MainPage.xaml
	/// </summary>
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
			ApplicationContext db = new ApplicationContext();

			User user = new User
			{
				ID = 1,
				Login = "213",
				Name = "elena",
				Password = "123",
				Surname = "nikola"
			};
			db.Users.Add(user);

			TestList testList = new TestList
			{
				ID = 1,
				Title = "title"
			};
			db.TestLists.Add(testList);
			TestQuestion test = new TestQuestion
			{
				ID = 1,
				Question = "question",
				CorrectAnswer = "123",
				TestList = testList
			};
			Answer answer = new Answer
			{
				ID = 1,
				Value = "Answer-1",
				Test = test
			};
			db.Answers.Add(answer);

			UserTestList userTestList = new UserTestList
			{
				ID = 1,
				TestList = testList,
				User = user,
				IsPassed = false
			};
			db.UserTestLists.Add(userTestList);

			db.SaveChanges();

			LViewTitles.ItemsSource = db.TestLists.ToList()[0].Tests.ToList();


		}
	}
}
