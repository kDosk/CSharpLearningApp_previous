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
            if (Textbox1.Text == TextBlock1.Text)
            {
                MessageBox.Show("Правильно1");
            }
            if (Textbox2.Text == TextBlock2.Text)
            {
                MessageBox.Show("Правильно3");
            }
            if (Textbox3.Text == TextBlock3.Text)
            {
                MessageBox.Show("Правильно2");
            }
            if (Textbox1.Text == TextBlock1.Text && Textbox2.Text == TextBlock2.Text && Textbox3.Text == TextBlock3.Text)
            {
                MessageBox.Show("Всё правильно!");
                NavigationService.Navigate(new MainPage());
            }
            else
            {
                MessageBox.Show("Где-то ошибка, переходим к теории");
                NavigationService.Navigate(new TheorySravpage());
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
