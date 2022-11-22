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

namespace CSharpLearningApp.Niyaz
{
    /// <summary>
    /// Логика взаимодействия для MainWindowArifm.xaml
    /// </summary>
    public partial class MainWindowArifm : Window
    {
        public MainWindowArifm()
        {
            InitializeComponent();
            PageNavigationManager.ChangePage(MainFrame, new MainPage());
            WindowNavigationManager.CurrentWindow = this;
        }
    }
}