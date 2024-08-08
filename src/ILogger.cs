﻿// Logging by Simon Field

using Logging.Broadcasting;

namespace Logging;

/// <summary>
/// A class that can broadcast messages of type <typeparamref name="T"/> to a logger.
/// </summary>
/// <typeparam name="T">The type of messages the implementing class can broadcast.</typeparam>
public interface ILogger<T>
{
    /// <summary>
    /// The broadcaster of type <typeparamref name="T"/> that is used to broadcast messages of type <typeparamref name="T"/>.
    /// </summary>
    public IBroadcaster<T> BCaster { get; }
}