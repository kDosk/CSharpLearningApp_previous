using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для ValidationPage.xaml
    /// </summary>
    public partial class ValidationPage : Page
    {
        public ValidationPage()
        {
            InitializeComponent();
            TextBlock1.Text = "Какой тип данных возвращает логические операции?";
            TextBlock2.Text = "Какие значение принимает bool?";
            TextBlock3.Text = "Что в себя включают условные конструкции?";
            TextBlock4.Text = "Что возвращает Операции сравнения?";
            TextBlock5.Text = "Условные выражения – сложные логические конструкции, в языке программирования C#, которые";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int b = 0;
            /*if (Radioint.IsChecked == false && Radiostring.IsChecked == false && RadioOtvet1.IsChecked == false)
            {
                b++;
            }
            if (true2.IsChecked == false && false2.IsChecked == false && RadioOtvet2.IsChecked == false)
            {
                b++;

            }
            if (Srav3.IsChecked== false && Log3.IsChecked==false && ObaNo3.IsChecked==false && RadioOtvet3.IsChecked==false) 
            {
                b++;
            }
            if (true4.IsChecked == false && false4.IsChecked == false && Yes4.IsChecked== false && No4.IsChecked == false && Yesno4.IsChecked == false && RadioOtvet4.IsChecked == false)
            {
                b++;
            }
            if (Isp5.IsChecked == false && IspUpr5.IsChecked==false && RadioOtvet5.IsChecked==false)
            {
                b++;

            }*/

            switch (RadioOtvet1.IsChecked)
            {
                case true:
                    a++;
                    break;
                case false:
                    switch (Radiostring.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                            case false:
                            switch (Radioint.IsChecked)
                            {
                                case true:
                                    b++;
                                    break;
                                    case false:
                                    MessageBox.Show("Первый вопрос не отвечен");
                                    break;
                            }
                            break;
                    }
                    break;
            }
            switch (RadioOtvet2.IsChecked)
            {
                case true:
                    a++;
                    break;
                case false:
                    switch (true2.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (false2.IsChecked)
                            {
                                case true:
                                    b++;
                                    break;
                                case false:
                                    MessageBox.Show("Второй вопрос не отвечен");
                                    break;
                            }
                            break;
                    }
                    break;
            }

            switch (RadioOtvet3.IsChecked)
            {
                case true:
                    a++;
                    break;
                case false:
                    switch (Srav3.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (Log3.IsChecked)
                            {
                                case true:
                                    b++;
                                    break;
                                case false:
                                    switch (ObaNo3.IsChecked)
                                    {
                                        case true:
                                            b++;
                                            break;
                                            case false:
                                            MessageBox.Show("Третий вопрос не отвечен");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
            switch (RadioOtvet4.IsChecked)
            {
                case true:
                    a++;
                    break;
                case false:
                    switch (true4.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (false4.IsChecked)
                            {
                                case true:
                                    b++;
                                    break;
                                case false:
                                    switch (Yes4.IsChecked)
                                    {
                                        case true:
                                            b++;
                                            break;
                                        case false:
                                            switch (No4.IsChecked)
                                            {
                                                case true:
                                                    b++;
                                                    break;
                                                case false:
                                                    switch (Yesno4.IsChecked)
                                                    {
                                                        case true:
                                                            b++;
                                                            break;
                                                        case false:
                                                            MessageBox.Show("Четвёртый вопрос не отвечен");
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }

            if (b == 5 || a==0)
            {
                MessageBox.Show("Ответьте на все вопросы");
            }
            if (a==2 || a==1)
            {
                MessageBox.Show("Оценка 2 перечитайте текст и перепройдите тест");
            }
            if (a==3) 
            {
                MessageBox.Show("Оценка 3 ");
            }
            if (a == 4)
            {
                MessageBox.Show("Оценка 4");
            }
            if (a == 5)
            {
                MessageBox.Show("Оценка 5");
            }
        }
    }
}
