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

                int correctAnswersCount = 0;

                switch (a1)
                {
                    case "2.5":
                        TBox1.Text = $"{a1}";
                        correctAnswersCount++;
						break;
					case "2,5":
						TBox1.Text = $"{a1}";
						correctAnswersCount++;
						break;
                }

                if (TextBlock1.Text == TBox3.Text && TextBlock2.Text == TBox2.Text && TextBlock3.Text == Textbox1.Text)
                {
					correctAnswersCount++;
				}

				if (b1 == "унарными" && c1 == "бинарными" && d1 == "тернарными")
				{
					correctAnswersCount++;
				}

                int score = 0;
                if (correctAnswersCount == 3)
                {
                    score = 5;
				}
                else if (correctAnswersCount == 2)
                {
                    score = 4;
                }
                else
                {
                    score = 2;
                }

				MessageService.ShowMessage($"Правильных ответов: {correctAnswersCount.ToString()} из 3. Оценка: {score}.");
                TestCalculate.ShowResult(score, "Арифметические операции", "type_2");
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
