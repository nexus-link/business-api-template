using System.Threading;
using System.Threading.Tasks;
using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement
{
    /// <summary>
    /// Service for invoices
    /// </summary>
    public interface IServicePackageService: IRead<ServicePackage, string>, IReadChildrenWithPaging<Service, string>
    {
        /// <summary>
        /// Get the number of active service packages for service package <paramref name="servicePackageId"/> for customer <paramref name="customerId"/>.
        /// </summary>
        Task<int> NumberOfActive(string servicePackageId, string customerId, CancellationToken token = default(CancellationToken));
    }
}
