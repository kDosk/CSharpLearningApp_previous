using CSharpLearningApp.Pages;
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
using System.Windows.Shapes;

namespace CSharpLearningApp
{
    /// <summary>
    /// Логика взаимодействия для MainKamilysWindow.xaml
    /// </summary>
    public partial class MainKamilysWindow : Window
    {
        public MainKamilysWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPageK());
            Manager.MainFrame = MainFrame;
        }
    }
}
