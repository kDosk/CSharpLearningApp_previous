using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class Practice
	{
		[Key]
		public int ID { get; set; }
		public string Task { get; set; }
		public string CorrectAnswer { get; set; }
		public int SubtitleID { get; set; }

		public Subtitle Subtitle { get; set; }
	}
}
