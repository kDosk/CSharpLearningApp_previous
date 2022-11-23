﻿using System;
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
    /// Логика взаимодействия для Practic.xaml
    /// </summary>
    public partial class Practic : Page
    {
        public Practic()
        {
            InitializeComponent();
            TextBox1QuestPract.Text = "1. Каким будет результат в выражении\r double z = 10.0 /  4.0;";
        }

        private void CheckPractic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string a1 = TBox1.Text.ToLower();
                string b1 = TBox31.Text.ToLower();
                string c1 = TBox32.Text.ToLower();
                string d1 = TBox33.Text.ToLower();

                int correctAswersCount = 0;

                switch (a1)
                {
                    case "2.5":
                        TBox1.Text = $"{a1}";
                        correctAswersCount++;
						break;
					case "2,5":
						TBox1.Text = $"{a1}";
						correctAswersCount++;
						break;
                }

                if (TextBlock1.Text == TBox3.Text && TextBlock2.Text == TBox2.Text && TextBlock3.Text == Textbox1.Text)
                {
					correctAswersCount++;
				}

				if (b1 == "унарными" && c1 == "бинарными" && d1 == "тернарными")
				{
					correctAswersCount++;
				}

				MessageService.ShowMessage($"Правильных ответов: {correctAswersCount.ToString()} из 3");
                PageNavigationManager.ChangePage(new MainPage());
            }
            catch (Exception)
            {

                MessageService.ShowError("Ошибка выполнения.");
                PageNavigationManager.ChangePage(new MainPage());
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
            TBox2.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void Textbox3_Drop(object sender, DragEventArgs e)
        {
            TBox3.Text = (string)e.Data.GetData(DataFormats.Text);
        }
    }
}