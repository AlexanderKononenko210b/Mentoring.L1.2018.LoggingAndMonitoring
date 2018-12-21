using PerformanceCounterHelper;

namespace MvcMusicStore.Infrastructure.PerformanceCounters
{
    /// <summary>
    /// Represents a <see cref="Counters"/> class.
    /// </summary>
    [PerformanceCounterCategory(
        "MvcMusicStore",
        System.Diagnostics.PerformanceCounterCategoryType.SingleInstance,
        "MvcMusicStore")]
    public enum Counters
    {
        [PerformanceCounter(
            "Log in successful count",
            "Log in successful",
            System.Diagnostics.PerformanceCounterType.NumberOfItems32)]
        LogIn,

        [PerformanceCounter(
        "Log off successful count",
        "Log off successful",
        System.Diagnostics.PerformanceCounterType.NumberOfItems32)]
        LogOff,

        [PerformanceCounter(
            "Visit site count",
            "Visit site",
            System.Diagnostics.PerformanceCounterType.NumberOfItems32)]
        VisitSite
    }
}