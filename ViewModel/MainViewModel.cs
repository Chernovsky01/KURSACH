using Models;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.Windows.Input;
using System.Xml;
using ViewModel.Commands;

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
        /// Свойство выбранной группы.
        /// </summary>
        private Category _selectedCategory;

        /// <summary>
        /// Свойство выбранной группы.
        /// </summary>
        public Category SelectedCategory
        {
            get => _selectedCategory;
            set => Set(ref _selectedCategory, value);
        }

        #endregion

        #region Selected Card

        /// <summary>
        /// Свойство выбранной карты
        /// </summary>
        private Card _selectedCard;

        /// <summary>
        /// Свойство выбранной карты
        /// </summary>
        public Card SelectedCard
        {
            get => _selectedCard;
            set => Set(ref _selectedCard, value);
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
            CompleteTaskCommand = new ActionCommand(OnCompleteTaskCommand, CanCompleteTaskCommand);

            #endregion
        }

        #region Add Category Command

        /// <summary>
        /// Команда для добавления новой категории.
        /// </summary>
        public ICommand AddCategoryCommand { get; }

        /// <summary>
        /// Метод, который определяет, можно ли добавить новую категорию.
        /// </summary>
        /// <param name="parametr"></param>
        /// <returns></returns>
        private bool CanAddCategoryCommand(object parametr) => true;

        /// <summary>
        /// Метод, выполняющий команду добавления новой категории.
        /// </summary>
        /// <param name="parametr"></param>
        private void OnAddCategoryCommand(object parametr)
        {
            // TODO - Сделать добавление категории через открытие нового окна.
        }

        #endregion

        #region Remove Category Command

        /// <summary>
        /// Команда для удаления категории.
        /// </summary>
        public ICommand RemoveCategoryCommand { get; }

        /// <summary>
        /// Метод, который определяет, можно ли удалить категорию.
        /// </summary>
        /// <param name="parametr"></param>
        /// <returns></returns>
        private bool CanRemoveCategoryCommand(object parametr) => true;

        /// <summary>
        /// Метод, выполняющий команду удаления категории.
        /// </summary>
        /// <param name="parametr"></param>
        private void OnRemoveCategoryCommand(object parametr) => Categories.Remove(SelectedCategory);

        #endregion

        #region Complete Task Command

        /// <summary>
        /// Команда для завершения задачи.
        /// </summary>
        public ICommand CompleteTaskCommand { get; }

        /// <summary>
        /// Метод, который определяет, можно ли завершить задачу.
        /// </summary>
        /// <param name="parametr"></param>
        /// <returns></returns>
        private bool CanCompleteTaskCommand(object parametr) => true;

        /// <summary>
        /// Метод, выполняющий команду завершения задачи.
        /// </summary>
        /// <param name="parametr"></param>
        private void OnCompleteTaskCommand(object parametr) => SelectedCard.IsDone = true;

        #endregion
    }

    // Environment.Exit(0); - Чтобы выйти из приложения.
}
