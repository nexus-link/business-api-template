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
    /// Service implementation of <see cref="ICustomerEndUserService"/>
    /// </summary>
    [Route("api/CustomerServiceManagement/v1/[controller]")]
    [ApiController]
    [Authorize(Policy = "HasMandatoryRole")]
    public abstract class CustomerEndUsersControllerBase : ICustomerEndUserService
    {
        /// <summary>
        /// The capability for this controller
        /// </summary>
        protected readonly ICustomerServiceManagementCapability Capability;

        /// <summary>
        /// The CrudController for this controller
        /// </summary>
        protected readonly ICrudSlaveToMasterBasic<ServicePackage, string> CrudController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capability">The logic layer</param>
        protected CustomerEndUsersControllerBase(ICustomerServiceManagementCapability capability)
        {
            Capability = capability;
        }

        /// <inheritdoc />
        [HttpGet("{id}/ServiceConfigurations")]
        public async Task<PageEnvelope<ServiceConfiguration>> ReadChildrenWithPagingAsync(string id, int offset, int? limit = null,
            CancellationToken token = new CancellationToken())
        {
            ServiceContract.RequireNotNullOrWhiteSpace(id, nameof(id));
            var page =await Capability.CustomerEndUserService.ReadChildrenWithPagingAsync(id, offset, limit, token);
            return page;
        }
    }
}
