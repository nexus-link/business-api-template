using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Libraries.Core.Error.Logic;
using Nexus.Link.Libraries.Crud.AspNet.ControllerHelpers;
using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning.Model;

namespace AcmeCorp.BusinessApi.Libraries.Controllers.Capabilities.ServiceProvisioning
{
    /// <summary>
    /// Service implementation of <see cref="ICaseService"/>
    /// </summary>
    [Route("api/ServiceProvisioning/v1/[controller]")]
    [ApiController]
    [Authorize(Policy = "HasMandatoryRole")]
    public abstract class CasesControllerBase : ICaseService
    {
        /// <summary>
        /// The capability for this controller
        /// </summary>
        protected readonly IServiceProvisioningCapability Capability;

        /// <summary>
        /// The CrudController for this controller
        /// </summary>
        protected readonly ICrud<CaseCreate, Case, string> CrudController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capability">The logic layer</param>
        protected CasesControllerBase(IServiceProvisioningCapability capability)
        {
            Capability = capability;
            CrudController = new CrudControllerHelper<CaseCreate, Case>(capability.Case);
        }

        /// <inheritdoc />
        [HttpPost("")]
        public virtual async Task<string> CreateAsync(CaseCreate item, CancellationToken token = default(CancellationToken))
        {
            return await CrudController.CreateAsync(item, token);
        }

        /// <inheritdoc />
        [HttpGet("{id}")]
        public virtual async Task<Case> ReadAsync(string id, CancellationToken token = default(CancellationToken))
        {
            var item = await CrudController.ReadAsync(id, token);
            if (item == null) throw new FulcrumNotFoundException($"No item found with id {id}.");
            return item;
        }

        /// <inheritdoc />
        [HttpPut("{id}")]
        public async Task UpdateAsync(string id, Case item, CancellationToken token = new CancellationToken())
        {
            await CrudController.UpdateAsync(id, item, token);
        }
    }
}
