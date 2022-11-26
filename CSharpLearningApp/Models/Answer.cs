using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class Answer
	{
		public int Id { get; set; }
		public string Value { get; set; }
		public bool IsCorrect { get; set; } = false;

		public int TestID { get; set; }
		public Test Test { get; set; }
	}
}
