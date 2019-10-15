using System;

namespace ManagerAPI.DataCore.DomainModel
{
    /// <summary>
    /// Описывает входные/выходные данные для метода
    /// </summary>
    public class DbContract : BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// Статус контракта
        /// </summary>
        public Guid StatusId { get; set; }
        public DbGenericType Status { get; set; }

        /// <summary>
        /// Исполнитель, тот кто исполняет метод
        /// </summary>
        public string Performer { get; set; }

        /// <summary>
        /// Исполнитель
        /// </summary>
        public string Initiator { get; set; }

        /// <summary>
        /// Описание контракта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Примечание к контаркту
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Входные данные метода
        /// </summary>
        public Guid? RequestObjectId { get; set; }
        public DbObject RequestObject { get; set; }

        /// <summary>
        /// То, что метод отдаст
        /// </summary>
        public Guid? ResponseObjectId { get; set; }
        public DbObject ResponseObject { get; set; }
    }
}
