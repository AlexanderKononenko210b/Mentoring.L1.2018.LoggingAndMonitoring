using NLog;
using MvcMusicStore.Infrastructure.Interfaces;

namespace MvcMusicStore.Infrastructure.Services
{
    /// <summary>
    /// Represents a <see cref="NlogService"/> class.
    /// </summary>
    public class NlogService : ILoggerService
    {
        private readonly Logger _logger;

        /// <summary>
        /// Initialize a new <see cref="NlogService"/> instance.
        /// </summary>
        public NlogService()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        ///<inheritdoc/>
        public void Error(string message)
        {
            _logger.Error(message);
        }

        ///<inheritdoc/>
        public void Info(string message)
        {
            _logger.Info(message);
        }

        ///<inheritdoc/>
        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        ///<inheritdoc/>
        public void Trace(string message)
        {
            _logger.Trace(message);
        }
    }
}