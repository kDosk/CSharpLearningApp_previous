using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpLearningApp.AmirFolder.AmirPages
{
    /// <summary>
    /// Логика взаимодействия для AmirImplicitTypingTest.xaml
    /// </summary>
    public partial class AmirImplicitTypingTest : Page
    {
        public AmirImplicitTypingTest()
        {
            InitializeComponent();
        }

        public int otc3 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (otvet12.IsChecked == true)
            {
                otc3++;
            }

            if (otvet22.IsChecked == true)
            {
                otc3++;
            }

            if (otvet33.IsChecked == true)
            {
                otc3++;
            }

            if (otvet41.IsChecked == true)
            {
                otc3++;
            }

            if (otvet52.IsChecked == true)
            {
                otc3++;
            }

            if (otc3 <= 2)
            {
                otc3 = 2;
            }

            AmirOcenki.ocenka3 = otc3;
            Manager.MainFrame.Navigate(new AmirOcenka3());
        }
    }
}
