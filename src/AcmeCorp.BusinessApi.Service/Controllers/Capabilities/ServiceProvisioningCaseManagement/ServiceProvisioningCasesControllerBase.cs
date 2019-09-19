using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning;
using AcmeCorp.BusinessApi.Libraries.Controllers.Capabilities.ServiceProvisioning;

namespace AcmeCorp.BusinessApi.Service.Controllers.Capabilities.ServiceProvisioningCaseManagement
{
    /// <inheritdoc />
    public class CasesController : CasesControllerBase
    {
        /// <inheritdoc />
        public CasesController(IServiceProvisioningCapability capability) : base(capability)
        {
        }
    }
}
