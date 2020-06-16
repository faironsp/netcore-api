using System;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }

        public virtual DateTime DateTimeCreated { get; set; } = DateTime.Now;

        public virtual DateTime DateTimeUpdated { get; set; } = DateTime.Now;
    }
}