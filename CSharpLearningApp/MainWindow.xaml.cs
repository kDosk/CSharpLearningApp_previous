using CSharpLearningApp.Rustem.Windows;
using CSharpLearningApp.TagirBranch;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MWMainPage());
            
        }

        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            switch (MainButton.Content)
            {
                case "Пользователь":
                    MainFrame.Navigate(new AuthPage());
                    MainButton.Content = "Назад";
                    break;
                default:
                    MainFrame.Navigate(new MWMainPage());
                    MainButton.Content = "Пользователь";
                    break;
            }
        }
    }
}
