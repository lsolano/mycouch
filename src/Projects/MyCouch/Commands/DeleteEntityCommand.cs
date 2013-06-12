﻿using System;
using EnsureThat;

namespace MyCouch.Commands
{
    [Serializable]
    public class DeleteEntityCommand<T> : IMyCouchCommand where T : class
    {
        public T Entity { get; set; }

        public DeleteEntityCommand(T entity)
        {
            Ensure.That(entity, "entity").IsNotNull();

            Entity = entity;
        }
    }
}