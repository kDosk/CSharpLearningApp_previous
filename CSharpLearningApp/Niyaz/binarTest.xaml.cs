using CSharpLearningApp.AmirFolder;
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
    /// Логика взаимодействия для binarTest.xaml
    /// </summary>
    public partial class binarTest : Page
    {
        public binarTest()
        {
            InitializeComponent();
            
        }
        public int otc1 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (otvet13.IsChecked == true)
            {
                otc1++;
            }

            if (otvet21.IsChecked == true)
            {
                otc1++;
            }

            if (otvet31.IsChecked == true)
            {
                otc1++;
            }

            if (otvet43.IsChecked == true)
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

            Niyazocenka.ocenka1 = otc1;
            NavigatonManager.ChangePage(new Ocenka1());
        }
    }
}
