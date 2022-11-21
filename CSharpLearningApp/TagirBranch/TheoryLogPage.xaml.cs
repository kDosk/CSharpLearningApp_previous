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
    /// Логика взаимодействия для TheoryLogPage.xaml
    /// </summary>
    public partial class TheoryLogPage : Page
    {
        public TheoryLogPage()
        {
            InitializeComponent();
            TextBlockTextss.Text = "Также в C# определены логические операторы, которые также возвращают значение типа bool." +
                " В качестве операндов они принимают значения типа bool. Как правило, применяются к отношениям и объединяют несколько операций сравнения." +
                "\r\n\r\n|\r\nОперация логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из операндов возвращает true." +
                "\r\nbool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, " +
                "поэтому возвращается true\r\nbool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false" +
                "\r\n\r&\r\nОперация логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true." +
                "\r\nbool x1 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false" +
                "\r\nbool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true" +
                "\r\n\r\n||\r\nОперация логического сложения. Возвращает true, если хотя бы один из операндов возвращает true." +
                "\r\nbool x1 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true" +
                "\r\nbool x2 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false" +
                "\r\n\r\n&&\r\nОперация логического умножения. Возвращает true, если оба операнда одновременно равны true." +
                "\r\nbool x1 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false" +
                "\r\nbool x2 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true" +
                "\r\n\r\n!\r\nОперация логического отрицания. Производится над одним операндом и возвращает true, если операнд равен false. " +
                "Если операнд равен true, то операция возвращает false:\r\nbool a = true;\r\nbool b = !a;    // false" +
                "\r\n\r^\r\nОперация исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, " +
                "иначе возвращает false\r\nbool x5 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true" +
                "\r\nbool x6 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false" +
                "\r\nЗдесь у нас две пары операций | и || (а также & и &&) выполняют похожие действия, однако же они не равнозначны." +
                "\r\n\r\nВ выражении z=x|y; будут вычисляться оба значения - x и y.\r\n\r\nВ выражении же z=x||y; сначала будет вычисляться значение x, " +
                "и если оно равно true, то вычисление значения y уже смысла не имеет, так как у нас в любом случае уже z будет равно true. " +
                "Значение y будет вычисляться только в том случае, если x равно false\r\n\r\nТо же самое касается пары операций &/&&. " +
                "В выражении z=x&y; будут вычисляться оба значения - x и y.\r\n\r\nВ выражении же z=x&&y; " +
                "сначала будет вычисляться значение x, и если оно равно false, то вычисление значения y уже смысла не имеет, " +
                "так как у нас в любом случае уже z будет равно false. Значение y будет вычисляться только в том случае, если x равно true" +
                "\r\n\r\nПоэтому операции || и && более удобны в вычислениях, так как позволяют сократить время на вычисление значения выражения, " +
                "и тем самым повышают производительность. А операции | и & больше подходят для выполнения поразрядных операций над числами.";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Click_ValidPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValidationLogPage());
        }
    }
}
