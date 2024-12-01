// Techkid.Logging by Simon Field

namespace Techkid.Logging.Broadcasting;

public class StringBroadcaster : Broadcaster<string>
{
    protected override string HandleMessageBasedOnMessageLogLevel(string message, LogLevel l)
    {
        return message;
    }

    protected override string HandleMessageBasedOnObserverLogLevelAndMessageLogLevel(string message, LogLevel messageLevel, LogLevel observerLevel)
    {
        if (observerLevel == LogLevel.Debug)
        {
            return $"[OBSERVER-{HashCode}] [{messageLevel.ToString().ToUpper()}] {message}";
        }

        return message;
    }

    protected override void AdditionalSubscriptionInstructions()
    {
        Broadcast($"New subscriber to broadcaster ({HashCode}), now with {Observers.Count} observers.", LogLevel.Debug);
    }

    public override IBroadcaster<string> Clone()
    {
        StringBroadcaster clone = new()
        {
            Observers = Observers
        };

        Broadcast($"Cloned broadcaster ({HashCode}) with {Observers.Count} observers into new broadcaster ({clone.HashCode}) with {clone.Observers.Count} observers.", LogLevel.Debug);

        return clone;
    }
}
