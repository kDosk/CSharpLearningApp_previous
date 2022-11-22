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
    /// Логика взаимодействия для TheoryPage.xaml
    /// </summary>
    public partial class TheoryPage : Page
    {
        public TheoryPage()
        {
            InitializeComponent();
            TextBlockTextss.Text = " Отдельный набор операций представляет условные выражения. " +
                "Такие операции возвращают логическое значение, то есть значение типа bool: true, если выражение истинно, и false, если выражение ложно. " +
                "К подобным операциям относятся операции сравнения и логические операции. Условные конструкции могут включать в себя:" +
                "\r\n\r\nОперации сравнения – это отдельная группа операторов, для сравнения значений, на вход принимают два аргумента одинакового типа данных, " +
                "а возвращают логическое значение true(истина) или false(ложь);\r\nЛогические операции – операторы, которые используются для работы " +
                "с логическим типом данных bool (название в .Net нотации System.Boolean).";

        }

        private void Click_ValidPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValidationPage());
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
