using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Services.Controllers.DataSync;
using AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Bearing;

namespace AcmeCorp.BusinessApi.Libraries.Controllers.DataSync.Bearing
{
    /// <summary>
    /// Service implementation of <see cref="ISyncUserService"/>
    /// </summary>
    [Route("api/DataSync/v1/[controller]")]
    [ApiController]
    [Authorize(Policy = "HasMandatoryRole")]
    public abstract class SyncUsersControllerBase : LegacySyncControllerBase<User>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logic">The logic layer</param>
        protected SyncUsersControllerBase(IBearingDataSync logic) : base(logic.SyncUserService)
        {
        }
    }
}
