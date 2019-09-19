using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Libraries.Core.Assert;
using Nexus.Link.Libraries.Core.Storage.Model;
using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning.Model;

namespace AcmeCorp.BusinessApi.Libraries.Controllers.Capabilities.ServiceProvisioning
{
    /// <summary>
    /// Service implementation of <see cref="ICustomerEndUserService"/>
    /// </summary>
    [Route("api/ServiceProvisioning/v1/[controller]")]
    [ApiController]
    [Authorize(Policy = "HasMandatoryRole")]
    public abstract class CustomerEndUsersControllerBase : ICustomerEndUserService
    {
        /// <summary>
        /// The capability for this controller
        /// </summary>
        protected readonly IServiceProvisioningCapability Capability;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capability">The logic layer</param>
        protected CustomerEndUsersControllerBase(IServiceProvisioningCapability capability)
        {
            Capability = capability;
        }

        /// <inheritdoc />
        [HttpGet("{id}/Cases")]
        public async Task<PageEnvelope<Case>> ReadChildrenWithPagingAsync(string id, int offset, int? limit = null,
            CancellationToken token = new CancellationToken())
        {
            ServiceContract.RequireNotNullOrWhiteSpace(id, nameof(id));
            var page =
                await Capability.CustomerEndUser.ReadChildrenWithPagingAsync(id, offset, limit, token);
            return page;
        }
    }
}
