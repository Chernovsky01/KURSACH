﻿using System;

namespace Models
{
    /// <summary>
    /// Класс, описывающий карточку с поставленной задачей.
    /// </summary>
    public class Card : BaseModel
    {
        #region Title of card

        /// <summary>
        /// Поле, которое содержит заголовок задачи.
        /// </summary>
        private string _title;
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        #endregion

        #region Task Description of card

        /// <summary>
        /// Поле, которое содержит описание задачи.
        /// </summary>
        private string _taskDescription;
        public string TaskDescription
        {
            get => _taskDescription;
            set => Set(ref _taskDescription, value);
        }

        #endregion

        #region Deadline of card

        /// <summary>
        /// Поле, которое содержит дедлайн задачи.
        /// </summary>
        private DateTime _deadline;
        public DateTime Deadline
        {
            get => _deadline;
            set => Set(ref _deadline, value);        }

        #endregion
    }
}
