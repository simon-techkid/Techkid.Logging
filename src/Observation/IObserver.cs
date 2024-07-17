// Logging by Simon Field

using System;

namespace Logging.Observation;

public interface IObserver<in T>
{
    bool Silent { get; set; }
    void OnCompleted();
    void OnError(Exception error);
    void OnNext(T value);
    LogLevel Level { get; }
    bool MessageMatcher(LogLevel lvl);
}
