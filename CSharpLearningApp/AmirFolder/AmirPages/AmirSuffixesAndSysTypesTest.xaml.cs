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
            otc2 = 0;
            if (otvet11.IsChecked == false && otvet12.IsChecked == false && otvet13.IsChecked == false
                || otvet21.IsChecked == false && otvet22.IsChecked == false && otvet23.IsChecked == false
                || otvet31.IsChecked == false && otvet32.IsChecked == false && otvet33.IsChecked == false
                || otvet41.IsChecked == false && otvet42.IsChecked == false && otvet43.IsChecked == false
                || otvet51.IsChecked == false && otvet52.IsChecked == false && otvet53.IsChecked == false)
            {
                MessageBox.Show("Выберbте ответы");
               
            }
            else
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
}
