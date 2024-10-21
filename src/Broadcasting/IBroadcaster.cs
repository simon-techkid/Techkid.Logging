// Logging by Simon Field

using System;
using System.Collections.Generic;

namespace Logging.Broadcasting;

public interface IBroadcaster<T>
{
    /// <summary>
    /// The observers of this broadcaster of type <typeparamref name="T"/>.
    /// </summary>
    public List<Observation.IObserver<T>> Observers { get; set; }

    /// <summary>
    /// The hash code of this broadcaster of type <typeparamref name="T"/>.
    /// </summary>
    public int HashCode { get; }

    /// <summary>
    /// Broadcast a message of type <typeparamref name="T"/> to all observers of type <typeparamref name="T"/>.
    /// The default log level for a message is <see cref="LogLevel.Info"/>.
    /// </summary>
    /// <param name="message">The contents of the message to broadcast.</param>
    /// <param name="level">The <see cref="LogLevel"/> of the message.</param>
    public void Broadcast(T message, LogLevel? level = null);

    /// <summary>
    /// Broadcast an error (of type <see cref="Exception"/>) to all observers of type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="error">An error of type <see cref="Exception"/>.</param>
    public void BroadcastError(Exception error);

    /// <summary>
    /// Broadcast a completion message to all observers of type <typeparamref name="T"/>.
    /// </summary>
    public void BroadcastCompletion();

    /// <summary>
    /// Subscribe an observer of type <typeparamref name="T"/> to the broadcaster of type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="observer">An observer of type <typeparamref name="T"/> which must match the broadcaster of type <typeparamref name="T"/>.</param>
    /// <returns>An <see cref="IDisposable"/> disposer that, when called, unsubscribes the observer from this broadcaster.</returns>
    public IDisposable Subscribe(Observation.IObserver<T> observer);

    /// <summary>
    /// Clone this broadcaster of type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>A new broadcaster.</returns>
    public IBroadcaster<T> Clone();
}
