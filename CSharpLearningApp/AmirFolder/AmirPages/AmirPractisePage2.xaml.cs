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

namespace CSharpLearningApp.AmirFolder.AmirPages
{
    /// <summary>
    /// Логика взаимодействия для AmirPractisePage2.xaml
    /// </summary>
    public partial class AmirPractisePage2 : Page
    {
        public AmirPractisePage2()
        {
            InitializeComponent();
            Text1.Text = ("Вместо прошлого, написанного текста, впишите:\r" +
                "int a;\r\na = 20;\rConsole.WriteLine(a);");
        }

        private void GoTestButton_Click(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "20")
            {
                MessageBox.Show("Практика пройденна");
                Manager.MainFrame.Navigate(new AmirMainPage());
            }
        }
    }
}
