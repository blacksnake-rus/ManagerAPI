using System;

namespace ManagerAPI.DataCore.DomainModel
{
    /// <summary>
    /// Описывает свойство объекта
    /// </summary>
    public class DbObjectProperty : BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// Тип свойства, как простой, так и класс
        /// </summary>
        public Guid DataTypeId { get; set; }
        public DbObject DataType { get; set; }

        /// <summary>
        /// Объект, к которому принадлежит свойство
        /// </summary>
        public Guid ObjectOwnerId { get; set; }
        public DbObject ObjectOwner { get; set; }

        /// <summary>
        /// Является ли свойство массивом элементов (Type)
        /// </summary>
        public bool IsArray { get; set; }

        /// <summary>
        /// Является ли свойство обязательным
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Статус свойства
        /// </summary>
        public Guid StatusId { get; set; }
        public DbGenericType Status { get; set; }

        /// <summary>
        /// Описание контракта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Примечание к контаркту
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Дефолтное значение
        /// </summary>
        public string DefaultValue { get; set; }
    }
}
