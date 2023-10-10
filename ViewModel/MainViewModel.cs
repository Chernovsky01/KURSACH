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
        private Category _selectedCategory;

        /// <summary>
        /// Свойство выбранной группы
        /// </summary>
        public Category SelectedCategory
        {
            get => _selectedCategory;
            set => Set(ref _selectedCategory, value);
        }

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

            AddCategoryCommand = new ActionCommand(OnAddCategoryCommand, CanAddCategoryCommand);
            RemoveCategoryCommand = new ActionCommand(OnRemoveCategoryCommand, CanRemoveCategoryCommand);

            #endregion
        }

        #region Add Category Command

        public ICommand AddCategoryCommand { get; }

        private bool CanAddCategoryCommand(object parametr) => true;

        private void OnAddCategoryCommand(object parametr)
        {
            // TODO - Сделать добавление категории через открытие нового окна
        }

        #endregion

        #region Remove Category Command

        public ICommand RemoveCategoryCommand { get; }

        private bool CanRemoveCategoryCommand(object parametr) => true;

        private void OnRemoveCategoryCommand(object parametr) => Categories.Remove(SelectedCategory);

        #endregion
    }
}
