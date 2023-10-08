using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Models
{
    /// <summary>
    /// Класс категории, который хранит набор карточек
    /// </summary>
    public class Category : BaseModel
    {
        /// <summary>
        /// Колекция, хранящая набор связанных с категорией карточек
        /// </summary>
        public ObservableCollection<Card> Cards { get; set; }
    }
}
