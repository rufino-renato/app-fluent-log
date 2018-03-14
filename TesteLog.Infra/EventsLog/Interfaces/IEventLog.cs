using TesteLog.Infra.EventsLog.Interfaces;

namespace TesteLog.Infra.EventLog.Interfaces
{
    public interface IEventLog
    {
        IEventLogInfo Info(string message);
        IEventLogWarn Warn(string message);
    }
}
