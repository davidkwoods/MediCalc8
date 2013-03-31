using System;
using System.Windows.Input;

namespace MediComponents
{
    class ActionCommand : ICommand
    {
        private readonly Action<object> _action;
        private readonly Predicate<object> _canExecute;

        public ActionCommand()
        {
            _action = _action ?? (x => { });
            _canExecute = _canExecute ?? (x => true);
        }

        public ActionCommand(Action<object> action) : this()
        {
            _action = action;
        }

        public ActionCommand(Action<object> action, Predicate<object> condition) : this(action)
        {
            _canExecute = condition;
        }

        #region ICommand Interface
        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
        #endregion
    }
}
