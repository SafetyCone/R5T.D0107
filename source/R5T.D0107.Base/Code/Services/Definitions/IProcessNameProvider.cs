using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0107
{
    [ServiceDefinitionMarker]
    public interface IProcessNameProvider : IServiceDefinition
    {
        Task<string> GetProcessName();
    }
}
