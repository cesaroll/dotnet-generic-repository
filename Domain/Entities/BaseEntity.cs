using System;
using GenericRepository;

namespace Domain.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }

        public BaseEntity()
        {
            Id = new Guid();
        }
    }
}