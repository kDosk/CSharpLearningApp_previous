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
    /// Логика взаимодействия для ValidationSravPage.xaml
    /// </summary>
    public partial class ValidationSravPage : Page
    {
        public ValidationSravPage()
        {
            InitializeComponent();
            TextBlock1.Text = "Какая операция сравнивает два операнда на равенство, если они равны то возвращает true?";
            TextBlock2.Text = "Какая операция сравнивает два операнда на равенство, если они не равны то возвращает true?"; 
            TextBlock3.Text = "Какая операция сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false?";
            TextBlock4.Text = "Какая операция сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. Иначе возвращает false?";
            TextBlock5.Text = "Какая операция сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false?";
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
                    switch (RV11.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (RV12.IsChecked)
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
                    switch (RV21.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (RV22.IsChecked)
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
                    switch (RV31.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (RV32.IsChecked)
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
            switch (RadioOtvet4.IsChecked)
            {
                case true:
                    a++;
                    break;
                case false:
                    switch (RV41.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (RV42.IsChecked)
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
            switch (RadioOtvet5.IsChecked)
            {
                case true:
                    a++;
                    break;
                case false:
                    switch (RV51.IsChecked)
                    {
                        case true:
                            b++;
                            break;
                        case false:
                            switch (RV52.IsChecked)
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
            MessageService.ShowMessage($"У вас {d} \r\rВопросы на которые не даны ответы:{c} \r\rВаша {otvet} поздравляю");
        }
    }
}
