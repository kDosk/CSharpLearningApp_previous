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
    /// Логика взаимодействия для PracticeLogPage.xaml
    /// </summary>
    public partial class PracticeLogPage : Page
    {
        public PracticeLogPage()
        {
            InitializeComponent();
            TextBlock1.Text = "Операция логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из операндов возвращает true.";
            TextBlock2.Text = "Операция логического сложения. Возвращает true, если хотя бы один из операндов возвращает true.";
            TextBlock3.Text = "Операция логического отрицания. Производится над одним операндом и возвращает true, если операнд равен false. Если операнд равен true, то операция возвращает false:\r\n\r\n";
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            string pr = null;
            if (Textbox1.Text == TextBlock1.Text)
            {
                a++;
            }
            else if (Textbox1.Text == "")
            {
                Textbox1.Text = "Пусто";
            }
            if (Textbox2.Text == TextBlock2.Text)
            {
                a++;
            }
            else if (Textbox2.Text == "")
            {
                Textbox2.Text = "Пусто";
            }
            if (Textbox3.Text == TextBlock3.Text)
            {
                a++;
            }
            else if (Textbox3.Text == "")
            {
                Textbox3.Text = "Пусто";
            }
            switch (a)
            {
                case 0:
                    pr = "Оценка 2";
                    break;
                case 1:
                    pr = "Оценка 3";
                    break;
                case 2:
                    pr = "Оценка 4";
                    break;
                case 3:
                    pr = "Оценка 5";
                    break;
            }

            MessageBoxResult result = MessageBox.Show($" У вас {pr} \r\rХотите выйти?", "Итог", MessageBoxButton.YesNoCancel, MessageBoxImage.Asterisk);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    NavigationService.Navigate(new MainPage());
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Тогда переходим к теории!");
                    NavigationService.Navigate(new TheoryLogPage());
                    break;
                default:
                    break;
            }
        }

        private void TextBlock1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(TextBlock1, TextBlock1.Text, DragDropEffects.Copy);
        }

        private void TextBlock2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(TextBlock2, TextBlock2.Text, DragDropEffects.Copy);
        }

        private void TextBlock3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(TextBlock3, TextBlock3.Text, DragDropEffects.Copy);
        }

        private void Textbox1_Drop(object sender, DragEventArgs e)
        {
            Textbox1.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void Textbox2_Drop(object sender, DragEventArgs e)
        {
            Textbox2.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void Textbox3_Drop(object sender, DragEventArgs e)
        {
            Textbox3.Text = (string)e.Data.GetData(DataFormats.Text);
        }
    }
}
