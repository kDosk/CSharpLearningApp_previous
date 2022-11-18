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
    /// Логика взаимодействия для TheoryPage2.xaml
    /// </summary>
    public partial class TheoryPage2 : Page
    {
        public TheoryPage2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.GoBack();
        }

        private void ButtonGoTest_Click(object sender, RoutedEventArgs e)
        {
            NavigatonManager.ChangePage(new TestPage2());
        }
    }
}
