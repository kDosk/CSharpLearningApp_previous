using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp
{
	internal class InfoStorage
	{
		public static string Inforamation { get; private set; }

		public static void SetInfo(string info)
		{
			Inforamation += info + "\r\n\r\n";
		}
	}
}
