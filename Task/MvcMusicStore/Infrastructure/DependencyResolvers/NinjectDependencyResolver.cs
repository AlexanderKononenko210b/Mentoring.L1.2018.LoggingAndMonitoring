using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace MvcMusicStore.Infrastructure.DependencyResolvers
{
    /// <summary>
    /// Represents a <see cref="NinjectDependencyResolver"/> class.
    /// </summary>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        /// <summary>
        /// Initialize a <see cref="NinjectDependencyResolver"/> instance.
        /// </summary>
        /// <param name="kernel"></param>
        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
            kernel.ConfigurateResolverWeb();
        }

        /// <summary>
        /// Get service.
        /// </summary>
        /// <param name="serviceType">The service type.</param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        /// <summary>
        /// Get services.
        /// </summary>
        /// <param name="serviceType">The service type.</param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}