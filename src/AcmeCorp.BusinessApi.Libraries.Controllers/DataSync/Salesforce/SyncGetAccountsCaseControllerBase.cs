using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Services.Controllers.DataSync;
using AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Salesforce;

namespace AcmeCorp.BusinessApi.Libraries.Controllers.DataSync.Salesforce
{
    /// <summary>
    /// Service implementation of <see cref="IInvoiceService"/>
    /// </summary>
    [Route("api/DataSync/v1/[controller]")]
    [ApiController]
    [Authorize(Policy = "HasMandatoryRole")]
    public abstract class SyncGetAccountsCaseControllerBase : LegacySyncControllerBase<GetAccountCase>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logic">The logic layer</param>
        protected SyncGetAccountsCaseControllerBase(ISalesforceDataSync logic) : base(logic.SyncGetAccountCaseService)
        {
        }
    }
}
    

