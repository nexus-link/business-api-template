using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement
{
    /// <summary>
    /// Service for invoices
    /// </summary>
    public interface IServiceConfigurationService: IRead<ServiceConfiguration, string>, IReadChildrenWithPaging<ServicePackage, string>
    {
    }
}
