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

namespace CSharpLearningApp.AmirFolder
{
    /// <summary>
    /// Логика взаимодействия для AmirPage22.xaml
    /// </summary>
    public partial class AmirPage22 : Page
    {
        public AmirPage22()
        {
            InitializeComponent();
            Text1.Text = (" Использование суффиксов"+
                "\rПри присвоении значений надо иметь в виду следующую тонкость: все вещественные литералы(дробные числа) рассматриваются как значения типа double.И чтобы указать, что дробное число представляет тип float или тип decimal, необходимо к литералу добавлять суффикс: F / f - для float и M / m - для decimal." +
                "\t\r\nfloat a = 3.14F;\r\nfloat b = 30.6f;\r\n \r\ndecimal c = 1005.8M;\r\ndecimal d = 334.8m;" +
                "\r\r\nПодобным образом все целочисленные литералы рассматриваются как значения типа int. Чтобы явным образом указать, что целочисленный литерал представляет значение типа uint, надо использовать суффикс U/u, для типа long - суффикс L/l, а для типа ulong - суффикс UL/ul:" +
                "\t\r\nuint a = 10U;\r\nlong b = 20L;\r\nulong c = 30UL;" +
                "\r\r\r\n Использование системных типов" +
                "\r\nВыше при перечислении всех базовых типов данных для каждого упоминался системный тип. Потому что название встроенного типа по сути представляет собой сокращенное обозначение системного типа. Например, следующие переменные будут эквивалентны по типу:" +
                "\t\r\nint a = 4;\r\nSystem.Int32 b = 4;");
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack(); 
        }

        private void GoTestBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirPage23());
        }
    }
}
