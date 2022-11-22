using CSharpLearningApp.AmirFolder.AmirPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для AmirDataTypesTest.xaml
    /// </summary>
    public partial class AmirDataTypesTest : Page
    {
        public AmirDataTypesTest()
        {
            InitializeComponent();
        }
        public int otc1 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            otc1 = 0;
            if (otvet11.IsChecked == false && otvet12.IsChecked == false && otvet13.IsChecked == false
                || otvet21.IsChecked == false && otvet22.IsChecked == false && otvet23.IsChecked == false
                || otvet31.IsChecked == false && otvet32.IsChecked == false && otvet33.IsChecked == false
                || otvet41.IsChecked == false && otvet42.IsChecked == false && otvet43.IsChecked == false
                || otvet51.IsChecked == false && otvet52.IsChecked == false && otvet53.IsChecked == false)
            {
                MessageBox.Show("Выберите ответы");
            }
            else
            {
               if (otvet13.IsChecked == true)
            {
                otc1++;
            }

            if (otvet21.IsChecked == true)
            {
                otc1++;
            }

            if (otvet32.IsChecked == true)
            {
                otc1++;
            }

            if (otvet41.IsChecked == true)
            {
                otc1++;
            }

            if (otvet52.IsChecked == true)
            {
                otc1++;
            }

            if (otc1 <= 2)
            {
                otc1 = 2;
            }
                AmirOcenki.ocenka1 = otc1;
                Manager.MainFrame.Navigate(new AmirOcenka1());
            }

        }

    }
}
