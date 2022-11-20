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

namespace CSharpLearningApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageK.xaml
    /// </summary>
    public partial class MainPageK : Page
    {
        public MainPageK()
        {
            InitializeComponent();
        }
        private void ButtonCapter1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PemenenniiTheory());

        }

        private void ButtonCapter2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new KonstantiTheory());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new PracticePage());
        }
    }
}
