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
        }

        private void RadioButtonBool_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Правильный ответ!");
        }

        private void RadioOba_checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Правильный ответ!");
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void ButtonTheory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TheoryPage());
        }
    }
}
