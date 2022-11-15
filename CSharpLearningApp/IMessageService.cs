using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp
{
    internal interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamination(string exclamination);
        void ShowError(string error);
    }
}
