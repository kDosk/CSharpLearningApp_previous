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
            NavigatonManager.ChangePage(new NiyazOcenka3());
        }
    }
}
