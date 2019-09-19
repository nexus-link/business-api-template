using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning
{
    /// <summary>
    /// Service for services
    /// </summary>
    public interface ICustomerEndUserService: IReadChildrenWithPaging<Case, string>
    {
    }
}
