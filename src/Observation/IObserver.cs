// Logging by Simon Field

namespace Logging.Observation;

public interface IObserver<in T> : System.IObserver<T>
{
    public bool Silent { get; set; }
    public LogLevel Level { get; }
    public bool MessageMatcher(LogLevel lvl);
}
