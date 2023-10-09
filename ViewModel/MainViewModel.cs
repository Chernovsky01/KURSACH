using Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ViewModel.Commands;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Список категорий
        /// </summary>
        ObservableCollection<Category> Categories = new ObservableCollection<Category>();

        #region Example command

        //public ICommand ExampleCommand { get; }

        //private bool CanExampleCommand(object parametr) => true;

        //private void OnExampleCommand(object parametr)
        //{
            
        //}

        #endregion

        public MainViewModel()
        {
            #region Commands

            //ExampleCommand = new ActionCommand(OnExampleCommand, CanExampleCommand);

            #endregion
        }
    }
}
