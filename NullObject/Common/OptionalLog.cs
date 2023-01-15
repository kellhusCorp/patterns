using NullObject.Interfaces;

namespace NullObject.Common;

public class OptionalLog : ILog
{
    private ILog log;

    public OptionalLog(ILog log)
    {
        this.log = log;
    }

    public void Info(string message)
    {
        log?.Info(message);
    }

    public void Warn(string message)
    {
        log?.Warn(message);
    }
}