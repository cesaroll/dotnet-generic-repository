using System;

namespace GenericRepository
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}