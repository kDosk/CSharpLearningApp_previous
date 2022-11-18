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
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Page
    {
        public Test1()
        {
            InitializeComponent();
            TextBlock1.Text = "Как обозначается базовая операция присваивания?";
            TextBlock2.Text = "Как обозначается дизъюнкция?";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
            if (Radio2.IsChecked == true)
            {
                MessageBox.Show("Правильный ответ! ");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }
          
            }
    }
}
