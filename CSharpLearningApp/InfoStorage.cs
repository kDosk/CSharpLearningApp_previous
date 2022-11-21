using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp
{
	internal class InfoStorage
	{
		public string Inforamation { get; set; } = "Нет данных.";

		public void SetInfo(string info)
		{
			Inforamation += info + "\r\n";
		}
	}
}
