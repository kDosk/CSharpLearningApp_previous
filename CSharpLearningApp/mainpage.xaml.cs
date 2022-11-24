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

namespace CSharpLearningApp
{
    /// <summary>
    /// Логика взаимодействия для mainpage.xaml
    /// </summary>
    public partial class mainpage : Page
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void Theory_ButtonClick1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1Teoriya());
        }

        private void Theory_ButtonClick2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2Teoriya());
        }

        private void Theory_ButtonClick3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3Teoriya());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Valibation_ButtonClick2(object sender, RoutedEventArgs e)
        {

        }

        private void Practice_ButtonClick1(object sender, RoutedEventArgs e)
        {

        }
        private void Valibation_ButtonClick3(object sender, RoutedEventArgs e)
        {

        }

        private void Practice_ButtonClick3(object sender, RoutedEventArgs e)
        {

        }
    }
}
