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

namespace CSharpLearningApp.AmirFolder
{
    /// <summary>
    /// Логика взаимодействия для AmirSuffixesAndSysTypesTest.xaml
    /// </summary>
    public partial class AmirSuffixesAndSysTypesTest : Page
    {
        public AmirSuffixesAndSysTypesTest()
        {
            InitializeComponent();
        }
        public int otc2;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (otvet11.IsChecked == true)
            {
                otc2++;
            }

            if (otvet23.IsChecked == true)
            {
                otc2++;
            }

            if (otvet32.IsChecked == true)
            {
                otc2++;
            }

            if (otvet43.IsChecked == true)
            {
                otc2++;
            }

            if (otvet51.IsChecked == true)
            {
                otc2++;
            }

            if (otc2 <= 2)
            {
                otc2 = 2;
            }

            AmirOcenki.ocenka2 = otc2;
            Manager.MainFrame.Navigate(new AmirOcenka2());
        }
    }
}
