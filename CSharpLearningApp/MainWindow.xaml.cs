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
        }

        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            //Переход к окну по названию нажатой кнопки
            switch ((sender as Button).Content)
            {
                case "Переменные и константы":
                    ShowWindow(new MainKamilysWindow());
                    break;
                case "Типы данных":
                    ShowWindow(new Window());
                    break;
                case "Арифметические вычисления":
                    ShowWindow(new Window());
                    break;
                case "Операции присваивания":
                    ShowWindow(new Window());
                    break;
                case "Преобразование базовых типов данных":
                    ShowWindow(new Window());
                    break;
                case "Условные выражения":
                    ShowWindow(new Window());
                    break;
                case "Циклы":
                    ShowWindow(new Window());
                    break;
                case "Массивы":
                    ShowWindow(new Window());
                    break;
                case "Методы":
                    ShowWindow(new Window());
                    break;
                case "Возвращение значения и оператор return":
                    ShowWindow(new Window());
                    break;
                case "Перечисления enum":
                    ShowWindow(new Window());
                    break;
                default:
                    MessageBox.Show("Ошибка выполнения.");
                    break;
            }
        }

        /// <summary>
        /// Метод открытия окна
        /// </summary>
        /// <param name="currentWindow">Название окна</param>
        private void ShowWindow(Window currentWindow)
        {
            currentWindow.ShowDialog();
        }
    }
}
