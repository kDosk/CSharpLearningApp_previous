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
    /// Логика взаимодействия для NiyazOcenka3.xaml
    /// </summary>
    public partial class NiyazOcenka3 : Page
    {
        public NiyazOcenka3()
        {
            InitializeComponent();
            if (Niyazocenka.ocenka3 <= 1)
            {
                OcenkaText.Text = ("Ваша оценка 2\r" + "Тест провален!");
            }
            if (Niyazocenka.ocenka3 == 2)
            {
                OcenkaText.Text = ("Ваша оценка 3\r" + "Удовлетворительно!");
            }

            if (Niyazocenka.ocenka3 == 3)
            {
                OcenkaText.Text = ("Ваша оценка 5\r" + "Тест пройден отлично!");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageNavigationManager.ChangePage(new MainPage());
        }
    }
    
}
