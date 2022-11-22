using CSharpLearningApp.AmirFolder;
using CSharpLearningApp.lilia;
using CSharpLearningApp.Niyaz;
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
    /// Логика взаимодействия для MWMainPage.xaml
    /// </summary>
    public partial class MWMainPage : Page
    {
        public MWMainPage()
        {
            InitializeComponent();
            TBoxinfo.Text = InfoStorage.Inforamation;
        }
        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            //Переход к окну по названию нажатой кнопки
            if (UserModel.CurrentUser != null)
            {
                switch ((sender as Button).Content)
                {
                    case "Переменные и константы":
                        ShowWindow(new MainKamilysWindow());
                        break;
                    case "Типы данных":
                        ShowWindow(new AmirWindow());
                        break;
                    case "Арифметические вычисления":
                        ShowWindow(new MainWindowArifm());
                        break;
                    case "Операции присваивания":
                        ShowWindow(new WindowLilia());
                        break;
                    case "Преобразование базовых типов данных":
                        ShowWindow(new Window());
                        break;
                    case "Условные выражения":
                        ShowWindow(new MainWindowTagir());
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
                    case "Оператор return":
                        ShowWindow(new BasicWindow());
                        break;
                    case "Перечисления enum":
                        ShowWindow(new Window());
                        break;
                    default:
                        MessageBox.Show("Ошибка выполнения.");
                        break;
                } 
            }
            else
            {
                MessageService.ShowError("Вход не выполнен.");
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
