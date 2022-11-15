using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLearningApp
{
    internal static class MessageService : IMessageService
    {
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static void ShowExclamination(string exclamination)
        {
            MessageBox.Show(exclamination, "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
        public static void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
