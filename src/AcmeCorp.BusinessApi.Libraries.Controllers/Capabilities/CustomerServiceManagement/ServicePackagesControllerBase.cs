using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Libraries.Core.Assert;
using Nexus.Link.Libraries.Core.Error.Logic;
using Nexus.Link.Libraries.Core.Storage.Model;
using Nexus.Link.Libraries.Crud.AspNet.ControllerHelpers;
using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model;

namespace AcmeCorp.BusinessApi.Libraries.Controllers.Capabilities.CustomerServiceManagement
{
    /// <summary>
    /// Service implementation of <see cref="IServicePackageService"/>
    /// </summary>
    [Route("api/CustomerServiceManagement/v1/[controller]")]
    [ApiController]
    [Authorize(Policy = "HasMandatoryRole")]
    public abstract class ServicePackagesControllerBase : IServicePackageService
    {
        /// <summary>
        /// The capability for this controller
        /// </summary>
        protected readonly ICustomerServiceManagementCapability Capability;

        /// <summary>
        /// The CrudController for this controller
        /// </summary>
        protected readonly ICrud<ServicePackage, string> CrudController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capability">The logic layer</param>
        protected ServicePackagesControllerBase(ICustomerServiceManagementCapability capability)
        {
            Capability = capability;
            CrudController = new CrudControllerHelper<ServicePackage>(capability.ServicePackage);
        }

        /// <inheritdoc />
        [HttpGet("{id}")]
        public async Task<ServicePackage> ReadAsync(string id, CancellationToken token = new CancellationToken())
        {
            var item = await CrudController.ReadAsync(id, token);
            if (item == null) throw new FulcrumNotFoundException($"No item found with id {id}.");
            return item;
        }

        /// <inheritdoc />
        [HttpGet("{servicePackageId}/Customer/{customerId}/NumberOfActive")]
        public async Task<int> NumberOfActive(string servicePackageId, string customerId, CancellationToken token = new CancellationToken())
        {
            ServiceContract.RequireNotNullOrWhiteSpace(servicePackageId, nameof(servicePackageId));
            ServiceContract.RequireNotNullOrWhiteSpace(customerId, nameof(customerId));
            var count = await Capability.ServicePackage.NumberOfActive(servicePackageId, customerId, token);
            return count;
        }

        /// <inheritdoc />
        [HttpGet("{id}/Services")]
        public async Task<PageEnvelope<Service>> ReadChildrenWithPagingAsync(string id, int offset, int? limit = null,
            CancellationToken token = new CancellationToken())
        {
            ServiceContract.RequireNotNullOrWhiteSpace(id, nameof(id));
            var page =
                await Capability.ServicePackage.ReadChildrenWithPagingAsync(id, offset, limit, token);
            return page;
        }
    }
}
