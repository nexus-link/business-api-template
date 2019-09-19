using Nexus.Link.Libraries.Crud.Interfaces;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement
{
    /// <summary>
    /// The services for the service configuration management capability
    /// </summary>
    public interface ICustomerServiceManagementCapability :  ICrudable
    {
        /// <summary>
        /// The service for getting a customer end users service configurations.
        /// </summary>
        ICustomerEndUserService CustomerEndUserService{ get; }
        /// <summary>
        /// The service for <see cref="ServiceConfiguration"/>.
        /// </summary>
        IServiceConfigurationService ServiceConfiguration{ get; }
        /// <summary>
        /// The service for <see cref="ServicePackage"/>.
        /// </summary>
        IServicePackageService ServicePackage{ get; }
        /// <summary>
        /// The service for <see cref="Service"/>.
        /// </summary>
        IServiceService Service{ get; }
    }
}
