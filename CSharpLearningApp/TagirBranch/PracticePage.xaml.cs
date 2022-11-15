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
    /// Логика взаимодействия для PracticePage.xaml
    /// </summary>
    public partial class PracticePage : Page
    {
        public PracticePage()
        {
            InitializeComponent();
            TextBlockTextss.Text = " Отдельный набор операций представляет условные выражения. " +
                "Такие операции возвращают логическое значение, то есть значение типа 1_____: 2_____, если выражение истинно, и 3_____, если выражение ложно." +
                " К подобным операциям относятся операции сравнения и логические операции.";

        }

        private void Textb1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Textb3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Textb2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
