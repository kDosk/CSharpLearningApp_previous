using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models
{
	internal class Subtitle
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int PageTitleId { get; set; }
		public PageTitle PageTitle { get; set; }
	}
}
