﻿using System;
using GenericRepository;

namespace Domain
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