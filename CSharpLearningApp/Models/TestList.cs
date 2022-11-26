using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class TestList
	{
		public int ID { get; set; }
		public List<Test> Tests { get; set; }
		public bool IsPassed { get; set; }

		public int UserID { get; set; }
		public User User { get; set; }
	}
}
