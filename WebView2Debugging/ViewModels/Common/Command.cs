using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WebView2Debugging.ViewModels
{
    public class Command : ICommand
    {
        private Func<object, bool> canExecute;
        private Action<object> execute;

        public Command(Action execute, Func<object, bool> canExecute = null)
        {
            this.execute = _ => execute();
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => canExecute?.Invoke(parameter) ?? true;

        public void Execute(object parameter) => execute?.Invoke(parameter);
    }
}