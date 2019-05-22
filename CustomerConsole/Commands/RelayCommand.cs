using System;
using System.Windows.Input;

namespace CustomerConsole.Commands
{
    public class RelayCommand : ICommand
    {
        Action<object> executeAction;
        Func<object, bool> canExecute;
        bool canExecuteCache;

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute, bool canExecuteCache)
        {
            this.executeAction = executeAction;
            this.canExecute = canExecute;
            this.canExecuteCache = canExecuteCache;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}
