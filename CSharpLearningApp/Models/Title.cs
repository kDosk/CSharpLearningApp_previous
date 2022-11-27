using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class Title
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public List<Subtitle> Subtitles { get; set; } = new List<Subtitle>();
	}
}
