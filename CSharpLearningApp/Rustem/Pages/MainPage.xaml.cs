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

namespace CSharpLearningApp.Rustem.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        #region TheoryPages EventArgs
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new TheoryPage1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new TheoryPage2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new TheoryPage3());
        } 
        #endregion

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
			NavigatonManager.ChangePage(new TestPage1());
		}

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
			NavigatonManager.ChangePage(new TestPage2());
		}
    }
}
