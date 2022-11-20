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

namespace CSharpLearningApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для KamilyaOcenka2.xaml
    /// </summary>
    public partial class KamilyaOcenka2 : Page
    {
        public KamilyaOcenka2()
        {
            InitializeComponent();
            { 
            if (KamilyaOcenki.ocenka2 <= 2)
            {
                OcenkaText.Text = ("Ваша оценка 2\r" + "Тест провален!");
            }

            if (KamilyaOcenki.ocenka2 == 3)
            {
                OcenkaText.Text = ("Ваша оценка 3\r" + "Тест пройден удовлетворительно!");
            }

            if (KamilyaOcenki.ocenka2 == 4)
            {
                OcenkaText.Text = ("Ваша оценка 4\r" + "Тест пройден хорошо!");
            }

            if (KamilyaOcenki.ocenka2 == 5)
            {
                OcenkaText.Text = ("Ваша оценка 5\r" + "Тест пройден отлично!");
            }
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Manager.MainFrame.GoBack();
        Manager.MainFrame.GoBack();
        Manager.MainFrame.GoBack();
    }
 }
}
