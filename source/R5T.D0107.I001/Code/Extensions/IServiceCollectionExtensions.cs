using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0107.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedProcessNameProvider"/> implementation of <see cref="IProcessNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedProcessNameProvider(this IServiceCollection services,
            string processName)
        {
            services.AddSingleton<IProcessNameProvider>(_ => new ConstructorBasedProcessNameProvider(
                processName));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EntryPointAssemblyProcessNameProvider"/> implementation of <see cref="IProcessNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEntryPointAssemblyProcessNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProcessNameProvider, EntryPointAssemblyProcessNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedProcessNameProvider"/> implementation of <see cref="IProcessNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedProcessNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProcessNameProvider, StaticValuedProcessNameProvider>();

            return services;
        }
    }
}