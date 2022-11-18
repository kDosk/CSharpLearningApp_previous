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

namespace CSharpLearningApp.Niyaz
{
    /// <summary>
    /// Логика взаимодействия для UnarTeory.xaml
    /// </summary>
    public partial class UnarTeory : Page
    {
        public UnarTeory()
        {
            InitializeComponent();
            inkrementBox.Text = "int x1 = 5; int z1 = ++x1; // z1=6; x1=6 Console.WriteLine($\"{x1} - {z1}\"); int x2 = 5; int z2 = x2++; // z2=5; x2=6  Console.WriteLine($\"{x2} - {z2}\");";
            dekrementBox.Text = "int x1 = 5; int z1 = --x1; // z1=4; x1=4 Console.WriteLine($\"{x1} - {z1}\"); int x2 = 5; int z2 = x2--; // z2=5; x2=4  Console.WriteLine($\"{x2} - {z2}\");";
            skobki.Text = "int a = 3; int b = 5; int c = 40; int d = c---b*a;    // a=3  b=5  c=39  d=25  Console.WriteLine($\"a={a}  b={b}  c={c}  d={d}\");";
        }

        private void BackUnarTeory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
