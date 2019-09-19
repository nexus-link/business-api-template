using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement;
using AcmeCorp.BusinessApi.Libraries.Controllers.Capabilities.CustomerServiceManagement;

namespace AcmeCorp.BusinessApi.Service.Controllers.Capabilities.CustomerServiceManagement
{
    /// <inheritdoc />
    public class CustomerEndUsersController : CustomerEndUsersControllerBase
    {
        /// <inheritdoc />
        public CustomerEndUsersController(ICustomerServiceManagementCapability capability) : base(capability)
        {
        }
    }
}
