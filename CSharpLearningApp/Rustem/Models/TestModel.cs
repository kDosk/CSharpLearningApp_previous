using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Rustem.Models
{
	internal class TestModel
	{
		public int ID { get; set; }
		public string Question { get; set; }
		public List<Answers> Answers { get; set; }
		public string CorrectAnswer { get; set; }

	}
	internal class Answers
	{
		public int Id { get; set; }
		public string Value { get; set; }
		public bool IsCorrect { get; set; } = false;
	}
}
