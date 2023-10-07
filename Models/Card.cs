using System;

namespace Models
{
    /// <summary>
    /// Класс, описывающий карточку с поставленной задачей.
    /// </summary>
    public class Card
    {
        #region Title of card
        /// <summary>
        /// Поле, которое содержит заголовок задачи.
        /// </summary>
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        #endregion

        #region Task Description of card
        /// <summary>
        /// Поле, которое содержит описание задачи.
        /// </summary>
        private string _taskDescription;
        public string TaskDescription
        {
            get { return _taskDescription; }
            set { _taskDescription = value; }
        }
        #endregion

        #region Deadline of card
        /// <summary>
        /// Поле, которое содержит дедлайн задачи.
        /// </summary>
        private DateTime _deadline;
        public DateTime Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
        #endregion
    }
}
