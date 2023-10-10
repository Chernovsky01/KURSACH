using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Models
{
    /// <summary>
    /// Класс категории, который хранит набор карточек
    /// </summary>
    public class Category : BaseModel
    {
        #region Category Title

        /// <summary>
        /// Поле, которое содержит заголовок категории.
        /// </summary>
        private string _title;

        /// <summary>
        /// Поле, которое содержит заголовок категории.
        /// </summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        #endregion

        /// <summary>
        /// Колекция, хранящая набор связанных с категорией карточек.
        /// </summary>
        public ICollection<Card> Cards { get; set; }
    }
}
