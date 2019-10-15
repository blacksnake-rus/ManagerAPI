using System;
using System.Collections.Generic;

namespace ManagerAPI.DataCore.DomainModel
{
    /// <summary>
    /// Некий тип данных
    /// </summary>
    public class DbObject : BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// Тип объекта, простой(string, ...) или класс(User) или объект request/response
        /// </summary>
        public Guid TypeId { get; set; }
        public DbGenericType Type { get; set; }

        /// <summary>
        /// Свойства объекта, у простого(string, ...) эта колекция будет пуста
        /// </summary>
        public ICollection<DbObjectProperty> ObjectProperties { get; set; }
    }
}
