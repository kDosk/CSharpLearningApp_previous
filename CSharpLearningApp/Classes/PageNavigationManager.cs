﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CSharpLearningApp
{
    internal class PageNavigationManager
    {
        private static Frame _currentFrame;

        /// <param name="currentPage">Окно</param>
        internal static void ChangePage(Page currentPage)
        {
            if (_currentFrame != null)
            {
                _currentFrame.Content = currentPage;
            }
            else
            {
                throw new Exception("_currentFrame пуст. Задайте Frame.");
            }
        }

        /// <param name="currentFrame">Элемент управления Frame</param>
        /// <param name="currentPage">Текущее окно</param>
        internal static void ChangePage(Frame currentFrame, Page currentPage)
        {
            _currentFrame = currentFrame;
            _currentFrame.Content = currentPage;
        }

        internal static void GoBack()
        {
            _currentFrame.NavigationService.GoBack();
        }
    }
}
