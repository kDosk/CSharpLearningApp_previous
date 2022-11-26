using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class Test
	{
		public int ID { get; set; }
		public string Question { get; set; }
		public List<Answer> Answers { get; set; }
		public string CorrectAnswer { get; set; }

		public int TestListId { get; set; }
		public TestList TestList { get; set; }

	}
}
