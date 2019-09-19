using Nexus.Link.Libraries.Crud.Interfaces;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning
{
    /// <summary>
    /// The services
    /// </summary>
    public interface IServiceProvisioningCapability :  ICrudable
    {
        /// <summary>
        /// The service for <see cref="Model.Case"/>.
        /// </summary>
        ICaseService Case { get; }

        /// <summary>
        /// The service for customer end user.
        /// </summary>
        ICustomerEndUserService CustomerEndUser { get; }
    }
}
