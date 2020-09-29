using System;

namespace BazaarDomain
{
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets identifier for the entity. 
        /// </summary>
        public int Id { get; set; }
    }
}
