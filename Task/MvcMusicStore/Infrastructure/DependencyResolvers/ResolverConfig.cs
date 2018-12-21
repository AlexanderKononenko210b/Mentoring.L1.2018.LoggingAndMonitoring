using MvcMusicStore.Infrastructure.Interfaces;
using MvcMusicStore.Infrastructure.PerformanceCounters;
using MvcMusicStore.Infrastructure.Services;
using Ninject;
using PerformanceCounterHelper;

namespace MvcMusicStore.Infrastructure.DependencyResolvers
{
    /// <summary>
    /// Represents a <see cref="ResolverConfig"/> class.
    /// </summary>
    public static class ResolverConfig
    {
        public static void ConfigurateResolverWeb(this IKernel kernel)
        {
            Configure(kernel);
        }

        private static void Configure(IKernel kernel)
        {
            kernel.Bind<ILoggerService>().To<NlogService>();
            kernel.Bind<CounterHelper<Counters>>().ToConstant(PerformanceHelper.CreateCounterHelper<Counters>());
        }
    }
}