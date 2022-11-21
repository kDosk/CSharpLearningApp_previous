using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLearningApp
{
    internal class WindowManager
    {
        public static Window CurrentWindow { get; set; }

        public void CloseWindow()
        {
            CurrentWindow.Close();
        }
    }
}
