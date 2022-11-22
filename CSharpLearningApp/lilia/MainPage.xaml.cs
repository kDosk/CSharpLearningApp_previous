using CSharpLearningApp.lilia;
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

namespace CSharpLearningApp.lilia
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void TheoryBaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new teorio());
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Test1());
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TEST2PED());

        }

        private void Practik_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new teorio_2());

        }
    }
}
