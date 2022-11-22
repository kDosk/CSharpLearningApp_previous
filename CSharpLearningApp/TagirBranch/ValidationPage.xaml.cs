using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                                    c = "Первый вопрос не отвечен";
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
