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
                "К подобным операциям относятся операции сравнения и логические операции. Здесь у нас две пары операций | и || (а также & и &&) выполняют " +
                "похожие действия, однако же они не равнозначны.\r\n\r\nВ выражении z=x|y; будут вычисляться оба значения - x и y.\r\n\r\nВ выражении же z=x||y; " +
                "сначала будет вычисляться значение x, и если оно равно true, то вычисление значения y уже смысла не имеет, так как у нас в любом случае уже z будет " +
                "равно true. Значение y будет вычисляться только в том случае, если x равно false\r\n\r\nТо же самое касается пары операций &/&&. В выражении z=x&y; " +
                "будут вычисляться оба значения - x и y.\r\n\r\nВ выражении же z=x&&y; сначала будет вычисляться значение x, и если оно равно false, то вычисление " +
                "значения y уже смысла не имеет, так как у нас в любом случае уже z будет равно false. Значение y будет вычисляться только в том случае, если x равно " +
                "true\r\n\r\nПоэтому операции || и && более удобны в вычислениях, так как позволяют сократить время на вычисление значения выражения, и тем самым повышают " +
                "производительность. А операции | и & больше подходят для выполнения поразрядных операций над числами.";

        }

        private void Click_ValidPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValidationLogPage());
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
