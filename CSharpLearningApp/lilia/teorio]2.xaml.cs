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

namespace CSharpLearningApp.lilia
{
    /// <summary>
    /// Логика взаимодействия для teorio_2.xaml
    /// </summary>
    public partial class teorio_2 : Page
    {
        public teorio_2()
        {
            InitializeComponent();
            TextBlockTexts1.Text = "Сначала будет вычисляться выражение 34 * 2 / 4, затем полученное значение будет присвоено переменным.\r\n\r\nКроме базовой операции присвоения в C# есть еще ряд операций:\r\n\r\n+=:" +
                " присваивание после сложения." +
                " Присваивает левому операнду сумму левого и правого операндов: выражение A += B" +
                " равнозначно выражению A = A + B\r\n\r\n-=: присваивание после вычитания. Присваивает левому операнду разность левого и правого операндов: A -= B эквивалентно A = A - B\r\n\r\n*=: присваивание после умножения." +
                " Присваивает левому операнду произведение левого и правого операндов: A *= B эквивалентно A = A * B\r\n\r\n/=:" +
                " присваивание после деления. Присваивает левому операнду частное левого и правого операндов: A /= B эквивалентно A = A / B\r\n\r\n%=: присваивание после деления по модулю." +
                " Присваивает левому операнду остаток от целочисленного деления левого операнда на правый: A %= B эквивалентно A = A % B\r\n\r\n&=: присваивание после поразрядной конъюнкции." +
                " Присваивает левому операнду результат поразрядной конъюнкции его битового представления с битовым представлением правого операнда: A &= B эквивалентно A = A & B\r\n\r\n";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Click_ValidPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TEST2PED());
        }
    }
}
