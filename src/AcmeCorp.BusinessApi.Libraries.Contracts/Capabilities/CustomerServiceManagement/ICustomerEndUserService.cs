using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement
{
    /// <summary>
    /// Service for services
    /// </summary>
    public interface ICustomerEndUserService: IReadChildrenWithPaging<ServiceConfiguration, string>
    {
    }
}
