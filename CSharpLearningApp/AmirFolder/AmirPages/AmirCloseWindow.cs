using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLearningApp.AmirFolder.AmirPages
{
    internal class AmirCloseWindow
    {
        public static Window AmirCloseWin { get; set; }

        public static void CloseWinds()
        {
            AmirCloseWin.Close();
        }
    }
}
