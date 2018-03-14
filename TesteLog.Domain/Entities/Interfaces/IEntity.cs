using System;
using System.Collections.Generic;
using System.Text;
using TesteLog.Infra.EventLog.Interfaces;
using TesteLog.Infra.EventsLog.Interfaces;

namespace TesteLog.Domain.Entities.Interfaces
{
    public interface IEntity<T> : IEventLog
    {
        Guid Id { get; }

        IEntity<T> Add();        

    }
}
