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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new binarTeory());
        }

           private void BinarTestBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new binarTest());
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new UnarTeory());
        }
        private void UnarTestBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new UnarTest());
        }

        private void UnarPractBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new Practic());
        }

        private void AssociatTeory_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new AssociationTeory());
        }

        private void AssociateTest_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new AssiciationTest());
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.CloseWindow();
        }
    }
}
