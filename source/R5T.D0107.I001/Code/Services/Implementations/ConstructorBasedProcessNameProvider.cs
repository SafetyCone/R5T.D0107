using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0107.I001
{
    [ServiceImplementationMarker]
    public class ConstructorBasedProcessNameProvider : IProcessNameProvider, IServiceImplementation
    {
        private string ProcessName { get; }


        public ConstructorBasedProcessNameProvider(
            [NotServiceComponent] string processName)
        {
            this.ProcessName = processName;
        }

        public Task<string> GetProcessName()
        {
            return Task.FromResult(this.ProcessName);
        }
    }
}
