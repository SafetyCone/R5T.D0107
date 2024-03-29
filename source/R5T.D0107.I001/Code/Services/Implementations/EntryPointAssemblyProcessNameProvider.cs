using System;
using System.Reflection;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0107.I001
{
    [ServiceImplementationMarker]
    public class EntryPointAssemblyProcessNameProvider : IProcessNameProvider, IServiceImplementation
    {
        public Task<string> GetProcessName()
        {
            var entryPointAssembly = Assembly.GetEntryAssembly();

            var entryPointAssemblyName = entryPointAssembly.GetName();

            return Task.FromResult(entryPointAssemblyName.Name);
        }
    }
}
