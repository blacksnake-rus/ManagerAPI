using System;

namespace ManagerAPI.DataCore
{
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор (первичный ключ)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Признак удаления
        /// </summary>
        public DateTime? DateOff { get; set; }
    }
}
