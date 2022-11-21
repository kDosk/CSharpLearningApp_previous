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
            switch (b1)
            {
                case "bool":
                    Textb1.Text = $"Правильно! {b1}";
                    break;
                default:
                    Textb1.Text = "Не верный ответ";
                    break;
            }
            switch (b2)
            {
                case "true":
                    Textb2.Text = $"Правильно! {b2}";
                    break;
                default:
                    Textb2.Text = "Не верный ответ";
                    break;
            }
            switch (b3)
            {
                case "false":
                    Textb3.Text = $"Правильно! {b3}";
                    break;
                default:
                    Textb3.Text = "Не верный ответ";
                    break;
            }
            if (b1 == ("bool") && b2==("true")&& b3==("false"))
            {
                MessageBox.Show("Всё правильно!");
                NavigationService.Navigate(new MainPage());
            }
            if (b1 != ("bool") || b2 != ("true") || b3 != ("false"))
            {
                MessageBox.Show("Повторика теорию");
                NavigationService.Navigate(new TheoryPage());
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
