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

namespace CSharpLearningApp.TagirBranch
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

        private void Theory_ButtonClick1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TheoryPage());
        }

        private void Validation_ButtonClick1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValidationPage());
        }

        private void Theory_ButtonClick2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TheorySravpage());
        }

        private void Validation_ButtonClick2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValidationSravPage());
        }

        private void Theory_ButtonClick3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TheoryLogPage());
        }

        private void Validation_ButtonClick3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValidationLogPage());
        }


        private void Practice_ButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PracticePage());
        }
    }
}
