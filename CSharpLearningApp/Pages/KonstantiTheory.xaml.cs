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
            Text1.Text = ("Отличительной особенностью переменных является то, что мы можем изменить их значение в процессе работы программы. Но, кроме того, в C# есть константы. Константа должна быть обязательно инициализирована при определении, и после определения значение константы не может быть изменено" +
    "\r\n\r\nКонстанты предназначены для описания таких значений, которые не должны изменяться в программе. Для определения констант используется ключевое слово const, которое указывается перед типом константы:" +
    "\t\r\nconst string NAME =\"Tom\";\r\n" +
    "\r\r\nТак, в данном случае определена константа NAME, которая хранит строку \"Tom\". Нередко для название констант используется верхний регистр, но это не более чем условность." +
    " При использовании констант надо помнить, что объявить мы их можем только один раз и что к моменту компиляции они должны быть определены. Так, в следующем случае мы получим ошибку, так как константе не присвоено начальное значение:" +
    "\r\n\r\nconst string NAME;" +
    "\t\r\nКроме того, мы ее не сможем изменим в процессе работы программы:" +
    "\r\r\nconst string NAME = \"Tom\"; " +
    "\t\r\n//NAME = \"Bob\";" +
    "\r\nТаким образом, если нам надо хранить в программе некоторые данные, но их не следует изменить, они определяются в виде констант. Если же их можно изменять, то они определяются в виде переменных.");
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
