// Logging by Simon Field

using System;

namespace Logging.Observation;

public interface IObserver<in T>
{
    public bool Silent { get; set; }
    public void OnCompleted();
    public void OnError(Exception error);
    public void OnNext(T value);
    public LogLevel Level { get; }
    public bool MessageMatcher(LogLevel lvl);
}
