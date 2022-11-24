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

namespace CSharpLearningApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для KonstantiTest.xaml
    /// </summary>
    public partial class KonstantiTest : Page
    {
        public KonstantiTest()
        {
            InitializeComponent();
        }
        public int otc3 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (otvet12.IsChecked == true)
            {
                otc3++;
            }

            if (otvet21.IsChecked == true)
            {
                otc3++;
            }

            if (otvet33.IsChecked == true)
            {
                otc3++;
            }

            if (otvet41.IsChecked == true)
            {
                otc3++;
            }

            if (otvet52.IsChecked == true)
            {
                otc3++;
            }

            if (otc3 <= 2)
            {
                otc3 = 2;
            }

            KamilyaOcenki.ocenka2 = otc3;

            TestCalculate.ShowResult(KamilyaOcenki.ocenka2, "Переменные и константы: Константы", "type_1");

            Manager.MainFrame.Navigate(new KamilyaOcenka2());
        }
    }
}