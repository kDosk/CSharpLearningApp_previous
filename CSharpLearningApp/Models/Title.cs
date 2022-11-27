using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class Title
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public List<Subtitle> Subtitles { get; set; } = new List<Subtitle>();
	}
}
