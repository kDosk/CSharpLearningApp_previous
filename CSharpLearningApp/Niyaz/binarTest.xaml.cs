﻿using CSharpLearningApp.AmirFolder;
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
    /// Логика взаимодействия для binarTest.xaml
    /// </summary>
    public partial class binarTest : Page
    {
        public binarTest()
        {
            InitializeComponent();
            
        }
        public int otc1 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            otc1 = 0;
            if (otvet11.IsChecked != true && otvet12.IsChecked != true && otvet13.IsChecked != true 
                || otvet21.IsChecked != true && otvet22.IsChecked != true && otvet23.IsChecked != true 
                || otvet31.IsChecked != true && otvet32.IsChecked != true && otvet33.IsChecked != true
                || otvet41.IsChecked != true && otvet42.IsChecked != true && otvet43.IsChecked != true
                || otvet51.IsChecked != true && otvet52.IsChecked != true && otvet53.IsChecked != true)
                {
                    MessageService.ShowMessage("Есть пустые ячейки");
                }
            else
            {
                if (otvet13.IsChecked == true)
                {
                    otc1++;
                }

                if (otvet21.IsChecked == true)
                {
                    otc1++;
                }

                if (otvet31.IsChecked == true)
                {
                    otc1++;
                }

                if (otvet43.IsChecked == true)
                {
                    otc1++;
                }

                if (otvet52.IsChecked == true)
                {
                    otc1++;
                }

                if (otc1 <= 2)
                {
                    otc1 = 2;
                }

                TestCalculate.ShowResult(otc1, "Арифметические операции: Бинарные операции", "type_1");

                Niyazocenka.ocenka1 = otc1;
                PageNavigationManager.ChangePage(new Ocenka1());
            }
        }
    }
}