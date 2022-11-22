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

namespace CSharpLearningApp.Niyaz
{
    /// <summary>
    /// Логика взаимодействия для AssiciationTest.xaml
    /// </summary>
    public partial class AssiciationTest : Page
    {
        public AssiciationTest()
        {
            InitializeComponent();
        }

        public int otc3;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            otc3 = 0;
            if (otvet11.IsChecked != true && otvet12.IsChecked != true && otvet13.IsChecked != true || otvet21.IsChecked != true && otvet22.IsChecked != true && otvet23.IsChecked != true || otvet31.IsChecked != true && otvet32.IsChecked != true && otvet33.IsChecked != true)
            {
                MessageService.ShowMessage("Есть пустые ячейки");

            }
            else
            {
                if (otvet12.IsChecked == true)
            {
                otc3++;
            }

            if (otvet21.IsChecked == true)
            {
                otc3++;
            }

            if (otvet31.IsChecked == true)
            {
                otc3++;
            }

            Niyazocenka.ocenka3 = otc3;
            PageNavigationManager.ChangePage(new NiyazOcenka3());
            }
            
        }
        
    }
}
