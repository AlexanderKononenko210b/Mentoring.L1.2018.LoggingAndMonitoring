using System.Web.Mvc;
using MvcMusicStore.Infrastructure.PerformanceCounters;
using PerformanceCounterHelper;

namespace MvcMusicStore.Infrastructure.DependencyResolvers
{
    /// <summary>
    /// Represents a <see cref="CountersConfigure"/> class.
    /// </summary>
    public static class CountersConfigure
    {
        private static readonly CounterHelper<Counters> _counter =
            DependencyResolver.Current.GetService(typeof(CounterHelper<Counters>)) as CounterHelper<Counters>;

        /// <summary>
        /// Reset all counters.
        /// </summary>
        public static void ResetCounters()
        {
            _counter.RawValue(Counters.LogIn, 0);
            _counter.RawValue(Counters.LogOff, 0);
            _counter.RawValue(Counters.VisitSite, 0);
        }
    }
}