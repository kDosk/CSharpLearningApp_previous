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
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace CSharpLearningApp.AmirFolder
{
    /// <summary>
    /// Логика взаимодействия для AmirWindow.xaml
    /// </summary>
    public partial class AmirWindow : Window
    {
        public AmirWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AmirPage1());
            Manager.MainFrame = MainFrame;
        }
    }
}