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
    /// Логика взаимодействия для Ocenka1.xaml
    /// </summary>
    public partial class Ocenka1 : Page
    {
        public Ocenka1()
        {
            InitializeComponent();
            if (Niyazocenka.ocenka1 <= 2)
            {
                OcenkaText.Text = ("Ваша оценка 2\r" + "Тест провален!");
            }

            if (Niyazocenka.ocenka1 == 3)
            {
                OcenkaText.Text = ("Ваша оценка 3\r" + "Тест пройден удовлетворительно!");
            }

            if (Niyazocenka.ocenka1 == 4)
            {
                OcenkaText.Text = ("Ваша оценка 4\r" + "Тест пройден хорошо!");
            }

            if (Niyazocenka.ocenka1 == 5)
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
