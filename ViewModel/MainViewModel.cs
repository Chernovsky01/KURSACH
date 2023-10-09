using Models;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.Windows.Input;
using System.Xml;
using ViewModel.Commands;
using System.Text.RegularExpressions;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Список категорий
        /// </summary>
        public ObservableCollection<Category> Categories { get; set; }

        #region Selected Group

        /// <summary>
        /// Свойство выбранной группы
        /// </summary>
        private Category _selectedGroup;

        /// <summary>
        /// Свойство выбранной группы
        /// </summary>
        public Category SelectedGroup
        {
            get => _selectedGroup;
            set => Set(ref _selectedGroup, value);
        }

        #endregion

        #region Example Command

        //public ICommand ExampleCommand { get; }

        //private bool CanExampleCommand(object parametr) => true;

        //private void OnExampleCommand(object parametr)
        //{

        //}

        #endregion

        public MainViewModel()
        {
            var cardIndex = 1;
            var cardsQuery = Enumerable.Range(1, 7).Select(c => new Card
            {
                Title = $"Карточка {cardIndex++}",
                TaskDescription = "Описание какой-то задача",
                Deadline = DateTime.Now
            });
            var categoriesQuery = Enumerable.Range(1, 4).Select(ct => new Category
            {
                Title = $"Категория {ct}",
                Cards = new ObservableCollection<Card>(cardsQuery)
            });

            Categories = new ObservableCollection<Category>(categoriesQuery);

            #region Commands

            //ExampleCommand = new ActionCommand(OnExampleCommand, CanExampleCommand);

            #endregion
        }
    }
}
