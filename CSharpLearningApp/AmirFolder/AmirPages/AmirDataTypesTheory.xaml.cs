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
    /// Логика взаимодействия для AmirPage2.xaml
    /// </summary>
    public partial class AmirPage2 : Page
    {
        public AmirPage2()
        {
            InitializeComponent();
            Text1.Text = "bool: хранит значение true или false (логические литералы). Представлен системным типом System.Boolean \r"+ "bool alive = true;\r\nbool isDead = false;\r\r"+
                "byte: хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte \r"+ "byte bit1 = 1;\r\nbyte bit2 = 102;\r\r" +
                "sbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte\r" +
                "sbyte bit1 = -101;\r\nsbyte bit2 = 102;\r\n\r" +
                "short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16" +
                "\t\r\nbyte bit1 = 1;\r\nbyte bit2 = 102;" +
                "\r\r\nsbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte" +
                "\t\r\nsbyte bit1 = -101;\r\nsbyte bit2 = 102;\r\n" +
                "\r\n\rshort: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16" +
                "\t\r\nshort n1 = 1;\r\nshort n2 = 102;\r\n" +
                "\r\n\rushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16" +
                "\t\r\nushort n1 = 1;\r\nushort n2 = 102;" +
                "\r\r\nint: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32. Все целочисленные литералы по умолчанию представляют значения типа int:" +
                "\t\r\nint a = 10;\r\nint b = 0b101;  // бинарная форма b =5\r\nint c = 0xFF;   // шестнадцатеричная форма c = 255\r\n" +
                "\r\r\nuint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32" +
                "\t\r\nuint a = 10;\r\nuint b = 0b101;\r\nuint c = 0xFF;" +
                "\r\r\nlong: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64" +
                "\t\r\nlong a = -10;\r\nlong b = 0b101;\r\nlong c = 0xFF;" +
                "\r\n\rfloat: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single" +
                "\r\n\r\ndouble: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. Представлен системным типом System.Double" +
                "\r\n\r\ndecimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal" +
                "\r\n\r\nchar: хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. Этому типу соответствуют символьные литералы:" +
                "\t\r\nchar a = 'A';\r\nchar b = '\\x5A';\r\nchar c = '\\u0420';" +
                "\r\r\nstring: хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют строковые литералы." +
                "\t\r\nstring hello = \"Hello\";\r\nstring word = \"world\";\r\n" +
                "\r\r\nobject: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET." +
                "\t\r\nobject a = 22;\r\nobject b = 3.14;\r\nobject c = \"hello code\";" +
                "\r\r\nНапример, определим несколько переменных разных типов и выведем их значения на консоль:" +
                "\t\r\nstring name = \"Tom\";\r\nint age = 33;\r\nbool isEmployed = false;\r\ndouble weight = 78.65;\r\nConsole.WriteLine($\"Имя: {name}\");\r\nConsole.WriteLine($\"Возраст: {age}\");\r\nConsole.WriteLine($\"Вес: {weight}\");\r\nConsole.WriteLine($\"Работает: {isEmployed}\");"
                ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirDataTypesTest());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void GoTestButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AmirDataTypesTest());
        }
    }
}
