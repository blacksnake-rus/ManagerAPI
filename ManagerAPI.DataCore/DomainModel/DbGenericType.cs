using System;

namespace ManagerAPI.DataCore.DomainModel
{
    /// <summary>
    /// Типы системы, статусы и т.п.
    /// </summary>
    public class DbGenericType : BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// Родительский тип
        /// </summary>
        public Guid? ParentId { get; set; }
        public DbGenericType Parent { get; set; }
    }
}
