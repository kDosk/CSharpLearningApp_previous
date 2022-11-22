using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLearningApp
{
    internal class WindowNavigationManager
    {
        public static Window CurrentWindow { get; set; }

        public static void CloseWindow()
        {
            CurrentWindow.Close();
        }
    }
}
