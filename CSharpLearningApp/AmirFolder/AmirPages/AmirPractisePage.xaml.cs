using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CSharpLearningApp.AmirFolder.AmirPages
{
    /// <summary>
    /// Логика взаимодействия для AmirPractisePage.xaml
    /// </summary>
    public partial class AmirPractisePage : Page
    {
        public AmirPractisePage()
        {
            InitializeComponent();  
            Text1.Text = ("Перейдите на сайт"+"https://www.onlinegdb.com/online_csharp_compiler,"+" через любой удобный браузер\r" +
                "Вместо строки:\r" +
                "Console.WriteLine(\"Hello World\");\r" +
                "Введите строки:\r" +
                "string name = \"Tom\";\r\nint age = 33;\r\nbool isEmployed = false;\r\ndouble weight = 78.65;\r\nConsole.WriteLine($\"Имя: {name}\");\r\nConsole.WriteLine($\"Возраст: {age}\");\r\nConsole.WriteLine($\"Вес: {weight}\");\r\nConsole.WriteLine($\"Работает: {isEmployed}\");" +
                "\rКакой получился результат:");
        }

        private void GoTestButton_Click(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "Имя: Tom\r\nВозраст: 33\r\nВес: 78.65\r\nРаботает: False")
            {
                Manager.MainFrame.Navigate(new AmirPractisePage2());
            }
            else
            {
                MessageBox.Show("Неверный код");
            }
        }

        private void TextBox_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Text2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


