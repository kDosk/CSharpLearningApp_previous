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

namespace CSharpLearningApp.AmirFolder
{
    /// <summary>
    /// Логика взаимодействия для AmirPage3.xaml
    /// </summary>
    public partial class AmirPage3 : Page
    {
        public AmirPage3()
        {
            InitializeComponent();
        }
        public int otc1 = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(otvet13.IsChecked == true)
            {
                otc1 ++;
            }

            if (otvet21.IsChecked == true)
            {
                otc1++;
            }

            if (otvet32.IsChecked == true)
            {
                otc1++;
            }

            if (otvet41.IsChecked == true)
            {
                otc1++;
            }

            if (otvet52.IsChecked == true)
            {
                otc1++;
            }

            if(otc1 <= 2)
            {
                otc1 = 2;
            }

            AmirOcenki.ocenka1 = otc1;
            Manager.MainFrame.Navigate(new Page1());
        }
    }
}