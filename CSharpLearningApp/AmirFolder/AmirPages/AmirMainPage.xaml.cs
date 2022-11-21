using CSharpLearningApp.AmirFolder.AmirPages;
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

namespace CSharpLearningApp.AmirFolder
{
    /// <summary>
    /// Логика взаимодействия для AmirMainPage.xaml
    /// </summary>
    public partial class AmirMainPage : Page
    {
        public AmirMainPage()
        {
            InitializeComponent();
        }

        private void ButtonCapter1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirPage2());           
        }

        private void ButtonCapter2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirSuffixesAndSysTypesTheory());
        }

        private void ButtonCapter3_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirImplicitTypingTheory());
        }

        private void ButtonPractise_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirPractisePage());
        }

        private void ButtonGoBack_Click(object sender, RoutedEventArgs e)
        {
            AmirCloseWindow.CloseWinds();
        }
    }
}
