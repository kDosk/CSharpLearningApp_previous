using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class UserTestList
	{
		[Key]
		public int ID { get; set; }
		public int UserID { get; set; }
		public bool IsPassed { get; set; } = false;
		public int TestListID { get; set; }


		public User User { get; set; }
		public TestList TestList { get; set; }
	}
}
