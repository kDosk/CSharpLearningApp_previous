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
    /// Логика взаимодействия для PemenenniiTheory.xaml
    /// </summary>
    public partial class PemenenniiTheory : Page
    {
        public PemenenniiTheory()
        {
            InitializeComponent();
            Text1.Text = "Синтаксис определения переменной выглядит следующим образом: \r" + "тип имя_переменной;\r\r" +
                "Вначале идет тип переменной, потом ее имя. В качестве имени переменной может выступать любое произвольное название, которое удовлетворяет следующим требованиям:" +
                "\r\r\n1.имя может содержать любые цифры, буквы и символ подчеркивания, при этом первый символ в имени должен быть буквой или символом подчеркивания" +
                "\r\r\n2.в имени не должно быть знаков пунктуации и пробелов" +
                "\r\r\n3.имя не может быть ключевым словом языка C#. Таких слов не так много, и при работе в Visual Studio среда разработки подсвечивает ключевые слова синим цветом." +
                "\r\r\nХотя имя переменой может быть любым, но следует давать переменным описательные имена, которые будут говорить об их предназначении:" +
                "\t\r\nstring name;" +
                "\r\r\nВ данном случае определена переменная name, которая имеет тип string. то есть переменная представляет строку. Поскольку определение переменной представляет собой инструкцию, то после него ставится точка с запятой." +
                "\r\r\nПри этом следует учитывать, что C# является регистрозависимым языком, поэтому следующие два определения переменных будут представлять две разные переменные:" +
                "\t\r\nstring name;" +
                "\t\r\nstring Name;" +
                "\r\r\nПосле определения переменной можно присвоить некоторое значение:" +
                "\t\r\nstring name;" +
                "\t\r\nname = \"Tom\";" +
                "\r\r\nТак как переменная name представляет тип string, то есть строку, то мы можем присвоить ей строку в двойных кавычках. Причем переменной можно присвоить только то значение, которое соответствует ее типу." +
                "\t\r\nВ дальнейшем с помощью имени переменной мы сможем обращаться к той области памяти, в которой хранится ее значение." +
                "\r\r\nТакже мы можем сразу при определении присвоить переменной значение. Данный прием называется инициализацией:" +
                "\t\r\nstring name = \"Tom\";\r\n" +
                "\r\r\nОтличительной чертой переменных является то, что в программе можно многократно менять их значение." +
                "\t\r\nНапример, создадим небольшую программу, в которой определим переменную, поменяем ее значение и выведем его на консоль:" +
                "\t\r\nstring name = \"Tom\";" +
                "\t\r\nConsole.WriteLine(name); " +
                "\t\r\nnname = \"Tom\";" +
                "\t\r\nConsole.WriteLine(name); "
                ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PemenenniiTest());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void GoTestButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PemenenniiTest());
        }
    }
}