using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0107.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedProcessNameProvider"/> implementation of <see cref="IProcessNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessNameProvider> AddConstructorBasedProcessNameProviderAction(this IServiceAction _,
            string processName)
        {
            var serviceAction = _.New<IProcessNameProvider>(services => services.AddConstructorBasedProcessNameProvider(
                processName));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="EntryPointAssemblyProcessNameProvider"/> implementation of <see cref="IProcessNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessNameProvider> AddEntryPointAssemblyProcessNameProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IProcessNameProvider>(services => services.AddEntryPointAssemblyProcessNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedProcessNameProvider"/> implementation of <see cref="IProcessNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessNameProvider> AddStaticValuedProcessNameProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IProcessNameProvider>(services => services.AddStaticValuedProcessNameProvider());
            return serviceAction;
        }
    }
}
