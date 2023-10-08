using System.Windows.Input;
using ViewModel.Commands;
using System.Windows;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region WindowTitle

        private string _windowTitle = "KURSACH";
		public string WindowTitle
		{
			get => _windowTitle;
			set => Set(ref _windowTitle, value);
		}

        #endregion

        #region Example command

        public ICommand ExampleCommand { get; }

        private bool CanExampleCommand(object parametr) => true;

        private void OnExampleCommand(object parametr)
        {

        }

        #endregion

        public MainViewModel()
        {
            #region Commands

            ExampleCommand = new ActionCommand(OnExampleCommand, CanExampleCommand);

            #endregion
        }
    }
}
