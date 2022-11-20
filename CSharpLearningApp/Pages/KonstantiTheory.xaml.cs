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

namespace CSharpLearningApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для KonstantiTheory.xaml
    /// </summary>
    public partial class KonstantiTheory : Page
    {
        public KonstantiTheory()
        {
            InitializeComponent();
            Text1.Text = ("Ранее мы явным образом указывали тип переменных, например, int x;. И компилятор при запуске уже знал, что x хранит целочисленное значение." +
    "\r\n\r\nОднако мы можем использовать и модель неявной типизации:" +
    "\t\r\nvar hello = \"Hell to World\";\r\nvar c = 20;" +
    "\r\r\nДля неявной типизации вместо названия типа данных используется ключевое слово var. Затем уже при компиляции компилятор сам выводит тип данных исходя из присвоенного значения. Так как по умолчанию все" +
    " целочисленные значения рассматриваются как значения типа int, то поэтому в итоге переменная c будет иметь тип int. Аналогично переменной hello присваивается строка, поэтому эта переменная будет иметь тип string" +
    "\r\n\r\nЭти переменные подобны обычным, однако они имеют некоторые ограничения.\r\n\r\nВо-первых, мы не можем сначала объявить неявно типизируемую переменную, а затем инициализировать:" +
    "\t\r\n// этот код работает\r\nint a;\r\na = 20;\r\n \r\n// этот код не работает\r\nvar c;\r\nc= 20;" +
    "\r\r\nВо-вторых, мы не можем указать в качестве значения неявно типизируемой переменной null:" +
    "\t\r\n// этот код не работает\r\nvar c=null;" +
    "\r\nТак как значение null, то компилятор не сможет вывести тип данных.");
        }

        private void GoTestButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new KonstantiTest());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
