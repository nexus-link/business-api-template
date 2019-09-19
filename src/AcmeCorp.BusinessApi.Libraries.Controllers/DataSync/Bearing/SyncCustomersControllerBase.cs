using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Services.Controllers.DataSync;
using AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Bearing;

namespace AcmeCorp.BusinessApi.Libraries.Controllers.DataSync.Bearing
{
    /// <summary>
    /// Service implementation of <see cref="ISyncCustomerService"/>
    /// </summary>
    [Route("api/DataSync/v1/Customer")]
    [ApiController]
    [Authorize(Policy = "HasMandatoryRole")]
    public abstract class SyncCustomersControllerBase: LegacySyncControllerBase<Customer>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logic">The logic layer</param>
        protected SyncCustomersControllerBase(IBearingDataSync logic) : base(logic.SyncCustomerService)
        {
        }
    }
}
