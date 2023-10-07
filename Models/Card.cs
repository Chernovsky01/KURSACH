using System;

namespace Models
{
    /// <summary>
    /// Класс, описывающий карточку с поставленной задачей.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Поле, которое содержит заголовок задачи.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Поле, которое содержит описание задачи.
        /// </summary>
        public string TaskDescription { get; set; }

        /// <summary>
        /// Поле, которое содержит дедлайн задачи.
        /// </summary>
        public DateTime Deadline { get; set; }
    }
}
