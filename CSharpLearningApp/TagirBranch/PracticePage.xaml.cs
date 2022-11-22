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

namespace CSharpLearningApp.TagirBranch
{
    /// <summary>
    /// Логика взаимодействия для PracticePage.xaml
    /// </summary>
    public partial class PracticePage : Page
    {
        public PracticePage()
        {
            InitializeComponent();
            TextBlockTextss.Text = " Отдельный набор операций представляет условные выражения. " +
                "Такие операции возвращают логическое значение, то есть значение типа 1_____: 2_____, если выражение истинно, и 3_____, если выражение ложно." +
                " К подобным операциям относятся операции сравнения и логические операции.";
            
        }
        


        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {
            string b1 = Textb1.Text;
            string b2 = Textb2.Text;
            string b3 = Textb3.Text;
            int a = 0;
            string pr = null;
            switch (b1)
            {
                case "bool":
                    Textb1.Text = "Правильно!";
                    a++;
                    break;
                case "":
                    Textb1.Text = "Пусто!";
                    break;
                default:
                    Textb1.Text = "Не верный ответ";
                    break;
            }
            switch (b2)
            {
                case "true":
                    Textb2.Text = "Правильно!";
                    a++;
                    break;
                case "":
                    Textb2.Text = "Пусто!";
                    break;
                default:
                    Textb2.Text = "Не верный ответ";
                    break;
            }
            switch (b3)
            {
                case "false":
                    Textb3.Text = "Правильно!";
                    a++;
                    break;
                case "":
                    Textb3.Text = "Пусто!";
                    break;
                default:
                    Textb3.Text = "Не верный ответ";
                    break;
            }

            switch (a)
            {
                    case 0:
                    pr = "нет правильных ответов";
                    break;
                    case 1:
                    pr = "один правильный ответ";
                    break;
                    case 2:
                    pr = "два правильных ответа";
                    break;
                    case 3:
                    pr = "три правильных ответа";
                    break;
            }
            MessageBoxResult result = MessageBox.Show($" У вас {pr} \r\rХотите перейти к следующей теме?", "Итог", MessageBoxButton.YesNoCancel, MessageBoxImage.Asterisk);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    NavigationService.Navigate(new TheorySravpage());
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Тогда переходим к теории!");
                    NavigationService.Navigate(new TheoryPage());
                    break;
                default:
                    break;
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
