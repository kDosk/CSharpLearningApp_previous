using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Packaging;
using System.Linq;
using System.Net.Http.Headers;
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
            string c = null;
            string d = null;
            string otvet = null;

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
                                    c = "\rПервый вопрос не отвечен";
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
                                    c = c + "\rВторой вопрос не отвечен";
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
                                            c = c + "\rТретий вопрос не отвечен";
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
                                                            c = c + "\rЧетвёртый вопрос не отвечен";
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
            switch (RadioOtvet5.IsChecked)
            {
                case true:
                    a++;
                    break;
                    case false:
                    switch (Isp5.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                            case false:
                            switch (IspUpr5.IsChecked)
                            {
                                case true:
                                    b++;
                                    break;
                                    case false:
                                    c = c + "\rПятый вопрос не отвечен";
                                    break;
                            }
                            break;
                    }
                    break;
            }
            switch (b)
            {
                case 0:
                    d = "ноль ошибок!";
                        break;
                case 1:
                    d = "одна ошибка!";
                    break;
                case 2:
                    d = "две ошибки!";
                    break;
                case 3:
                    d = "три ошибки!";
                    break;
                case 4:
                    d = "четыре ошибки!";
                    break;
                case 5:
                    d = "пять ошибок!";
                    break;
            }
            switch (a)
            {
                case 0:
                case 1:
                case 2:
                    otvet = "оценка 2";
                    break;
                case 3:
                    otvet = "оценка 3";
                    break;
                case 4:
                    otvet = "оценка 4";
                    break;
                case 5:
                    otvet = "оценка 5";
                    break;
            }
           MessageBoxResult result = MessageBox.Show($"У вас {d} \r\rВопросы на которые не даны " +
               $"ответы:{c} \r\rВаша {otvet} поздравляю \r\rХотите перейти дальше?" , "Итог" , MessageBoxButton.YesNoCancel, MessageBoxImage.Asterisk);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    NavigationService.Navigate(new PracticePage());
                    break;
                        case MessageBoxResult.No:
                        MessageBox.Show("Тогда переходим к теории!");
                    NavigationService.Navigate(new TheoryPage());
                    break;
                default:
                    break;
            }
        }
    }
}
