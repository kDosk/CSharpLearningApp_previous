using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class TestList
	{
		//[Key]
		public int ID { get; set; }
		public string Title { get; set; }
		
		public List<TestQuestion> Tests { get; set; } = new List<TestQuestion>();
		
	}
}
