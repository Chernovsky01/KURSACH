using System;

namespace Models
{
    /// <summary>
    /// Класс, описывающий карточку с поставленной задачей.
    /// </summary>
    public class Card : BaseModel
    {
        #region Card Title

        /// <summary>
        /// Поле, которое содержит заголовок задачи.
        /// </summary>
        private string _title;

        /// <summary>
        /// Поле, которое содержит заголовок задачи.
        /// </summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        #endregion

        #region Card Description

        /// <summary>
        /// Поле, которое содержит заголовок задачи.
        /// </summary>
        private string _taskDescription;

        /// <summary>
        /// Поле, которое содержит описание задачи.
        /// </summary>
        public string TaskDescription
        {
            get => _taskDescription;
            set => Set(ref _taskDescription, value);
        }

        #endregion

        #region Card Deadline

        /// <summary>
        /// Поле, которое содержит дедлайн задачи.
        /// </summary>
        private DateTime _deadline;

        /// <summary>
        /// Поле, которое содержит дедлайн задачи.
        /// </summary>
        public DateTime Deadline
        {
            get => _deadline;
            set => Set(ref _deadline, value);
        }

        #endregion

        #region Card Status IsDone

        /// <summary>
        /// Поле, которое показывает, выполнена ли задача.
        /// </summary>
        private bool _isDone;

        /// <summary>
        /// Поле, которое показывает, выполнена ли задача.
        /// </summary>
        public bool IsDone
        {
            get => _isDone;
            set => Set(ref _isDone, value);
        }

        #endregion
    }
}
