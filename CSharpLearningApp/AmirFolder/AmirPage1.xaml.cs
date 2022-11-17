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
    /// Логика взаимодействия для AmirPage1.xaml
    /// </summary>
    public partial class AmirPage1 : Page
    {
        public AmirPage1()
        {
            InitializeComponent();
        }

        private void ButtonCapter1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirPage2());
            
        }

        private void ButtonCapter2_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirPage22());
        }

        private void ButtonCapter3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
