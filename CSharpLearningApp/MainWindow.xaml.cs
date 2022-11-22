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
            TBoxinfo.Text = InfoStorage.Inforamation;
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
                    ShowWindow(new AmirFolder.AmirWindow());
                    break;
                case "Арифметические операции":
                    ShowWindow(new Niyaz.MainWindowArifm());
                    break;
                case "Операции присваивания":
                    MessageService.ShowExclamination("Данный элемент еще не готов");
                    break;
                case "Преобразование базовых типов данных":
                    MessageService.ShowExclamination("Данный элемент еще не готов");
                    break;
                case "Условные выражения":
                    ShowWindow(new MainWindowTagir());
                    break;
                case "Циклы":
                    MessageService.ShowExclamination("Данный элемент еще не готов");
                    break;
                case "Массивы":
                    MessageService.ShowExclamination("Данный элемент еще не готов");
                    break;
                case "Методы":
                    MessageService.ShowExclamination("Данный элемент еще не готов");
                    break;
                case "Возвращение значения и оператор return":
                    ShowWindow(new BasicWindow());
                    break;
                case "Перечисления enum":
                    MessageService.ShowExclamination("Данный элемент еще не готов");
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
			if (new AuthWindow().ShowDialog() == true)
            {
                currentWindow.ShowDialog();
            }
        }
    }
}
