using Serilog;
using System;
using TesteLog.Domain.Entities.Interfaces;
using TesteLog.Infra.EventsLog.Interfaces;

namespace TesteLog.Domain.Entities
{
    public abstract class Entity<T> : IEntity<T>
    {
        public Guid Id { get; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public IEntity<T> Add()
        {
            return this;
        }

        public IEventLogInfo Info(string message)
        {
            Log.Information(message);
            return (IEventLogInfo)this;
        }

        public IEventLogWarn Warn(string message)
        {
            Log.Warning(message);
            return (IEventLogWarn)this;
        }
    }
}
