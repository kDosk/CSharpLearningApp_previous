using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CSharpLearningApp.Classes.Navigation
{
	internal static class NavigationManager
	{
		public static Frame CurrentFrame { get; set; }
		public static Window CurrentWindow { get; set; }
	}
}
