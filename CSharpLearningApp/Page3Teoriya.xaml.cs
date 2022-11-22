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

namespace CSharpLearningApp
{
    /// <summary>
    /// Логика взаимодействия для Page3Teoriya.xaml
    /// </summary>
    public partial class Page3Teoriya : Page
    {
        public Page3Teoriya()
        {
            InitializeComponent();
            TextBlockTextss4.Text = "В структурном программировании признаются полезными переходы вперед (но не назад), позволяющие при выполнении некоторого условия выйти из цикла, из оператора выбора, из блока. " +
                " Для этой цели можно использовать оператор goto, но лучше применять специально предназначенные для этих целей операторы break и continue." +
                " Однократное выполнение блока цикла называется итерацией." +
                " Операторы continue/break с меткой используются в том случае, если в программе присутствуют вложенные циклы. " +
                " При этом break с меткой обеспечивает полный выход изо всех вложенных циклов." +
                " А continue с меткой выходит из текущего вложенного цикла с последующим переходом к очередной итерации внешнего цикла. " +
                " Оператор break применяется для прерывания текущей итерации (break (broke, broken) — ломать, разрывать). " +
                " С его помощью происходит выход из блока фигурных скобок оператора цикла либо оператора switch с дальнейшей передачей управления следующему оператору." +
                " Если задействуются вложенные операторы, break обеспечивает выход из самого внутреннего оператора." +
                " А что если мы хотим, чтобы при проверке цикл не завершался, а просто пропускал текущую итерацию. " +
                " Для этого мы можем воспользоваться оператором continue " +
                " Оператор continue предназначен для перехода к выполнению следующей итерации цикла. " +
                " Если в теле цикла встречается оператор continue, " +
                " то: выполнение текущей итерации останавливается происходит переход к следующей итерации цикла" +
                " Оператор continue осуществляет принудительный переход к следующему шагу цикла, пропуская любой код, оставшийся невыполненным. " +
                " Таким образом, оператор continue служит своего рода дополнением оператора break." +
                " Вложенные циклы – это циклы, организованные в теле другого цикла. " +
                " Вложенный цикл в тело другого цикла, называется внутренним циклом. " +
                " Цикл, в теле которого существует вложенный цикл, называется внешним.";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Click_ValidPage1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3Test());
        }
    }
}
