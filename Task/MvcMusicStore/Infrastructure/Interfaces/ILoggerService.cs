namespace MvcMusicStore.Infrastructure.Interfaces
{
    /// <summary>
    /// Represents an <see cref="ILoggerService"/> interface.
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>
        /// Write error.
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(string message);

        /// <summary>
        /// Write info.
        /// </summary>
        /// <param name="message">The message.</param>
        void Info(string message);

        /// <summary>
        /// Write debug.
        /// </summary>
        /// <param name="message">The message.</param>
        void Debug(string message);

        /// <summary>
        /// Write trace.
        /// </summary>
        /// <param name="message">The message.</param>
        void Trace(string message);
    }
}