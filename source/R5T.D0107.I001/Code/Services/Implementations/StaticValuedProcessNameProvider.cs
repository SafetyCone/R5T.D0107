using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0107.I001
{
    [ServiceImplementationMarker]
    public class StaticValuedProcessNameProvider : IProcessNameProvider, IServiceImplementation
    {
        public static string ProcessName { get; set; }


        public Task<string> GetProcessName()
        {
            return Task.FromResult(StaticValuedProcessNameProvider.ProcessName);
        }
    }
}
