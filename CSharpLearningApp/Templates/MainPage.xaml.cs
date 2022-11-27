using CSharpLearningApp.Classes;
using CSharpLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
			db.Tests.Load();
			db.TestLists.Load();
			db.Answers.Load();
			var data = db.TestLists.Local.ToObservableCollection()[0].TestQuestions.ToList();

			LViewTitles.ItemsSource = data;


		}
	}
}
