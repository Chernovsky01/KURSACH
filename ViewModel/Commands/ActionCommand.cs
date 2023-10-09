using System;

namespace ViewModel.Commands
{
    /// <summary>
    /// Основная команда
    /// </summary>
    public class ActionCommand : BaseCommand
    {
        /// <summary>
        /// Выполняемое экшен команды
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Условие выполнения команды
        /// </summary>
        private readonly Func<object, bool> _canExecute;

        /// <summary>
        /// Конструктор команды.
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public override bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _execute(parameter);
    }
}
