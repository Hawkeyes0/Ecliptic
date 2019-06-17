using System;
using System.ComponentModel.DataAnnotations;

namespace Ecliptic.Entities
{
    /// <summary>一切对象的基类，定义了公共属性</summary>
    public abstract class Entity<TKey>
    {
        /// <summary>ID</summary>
        [Key]
        public TKey Id { get; set; }

        public DateTime CreateDate { get; set; }

        public TKey CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        public TKey UpdateUser { get; set; }
    }
}