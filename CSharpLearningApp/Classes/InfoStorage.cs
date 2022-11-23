using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp
{
	internal class InfoStorage
	{
		private static string _information;
		public static string Inforamation
		{
			get { return _information; }
			set { _information += value + "\r\n"; }
		}
	}
}
