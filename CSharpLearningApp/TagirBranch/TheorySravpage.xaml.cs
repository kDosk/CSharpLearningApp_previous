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
    /// Логика взаимодействия для TheorySravpage.xaml
    /// </summary>
    public partial class TheorySravpage : Page
    {
        public TheorySravpage()
        {
            InitializeComponent();
            TextBlockTextss.Text = "В операциях сравнения сравниваются два операнда и возвращается значение типа bool - true, " +
                "если выражение верно, и false, если выражение неверно. \r\n\r==\r\nСравнивает два операнда " +
                "на равенство. Если они равны, то операция возвращает true, если не равны, то " +
                "возвращается false:\r\nint a = 10;\r\nint b = 4;\r\nbool c = " +
                "a == b; // false \r\n\r!=\r\nСравнивает два операнда и возвращает " +
                "true, если операнды не равны, и false, если они равны.\r\nint a = 10;\r\nint b = 4;\r\nbool c = a != b;    " +
                "// true\r\nbool d = a!=10;     // false\r\n\r<\r\nОперация \"меньше чем\". Возвращает true, " +
                "если первый операнд меньше второго, и false, если первый операнд больше второго:" +
                "\r\nint a = 10;\r\nint b = 4;\r\nbool c = a < b; // false\r\n\r>\r\nОперация \"больше чем\". " +
                "Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false:" +
                "\r\nint a = 10;\r\nint b = 4;\r\nbool c = a > b;     // true\r\nbool d = a > 25;    // false\r\n\r<=\r\nОперация " +
                "\"меньше или равно\". Сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. " +
                "Иначе возвращает false.\r\nint a = 10;\r\nint b = 4;\r\nbool c = a <= b;   " +
                "// false\r\nbool d = a <= 25;    // true\r\n\r>=\r\nОперация \"больше или равно\". Сравнивает два операнда и " +
                "возвращает true, если первый операнд больше или равен второму, иначе возвращается false:\r\nint a = 10;\r\nint b = 4;" +
                "\r\nbool c = a >= b;     // true\r\nbool d = a >= 25;    // false\r\nОперации <, > <=, >= имеют больший приоритет, чем == и !=.";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Click_ValidPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValidationSravPage());
        }
    }
}
