using Nexus.Link.Libraries.Core.Storage.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model
{
    /// <summary>
    /// Data type for a service package 
    /// </summary>
    public class ServicePackage: IUniquelyIdentifiable<string>
    {
        /// <summary>
        /// The id of service package configuration
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The id of the service package configuration
        /// </summary>
        public string ServicePackageConfigurationId { get; set; }

        /// <summary>
        /// The title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The status
        /// </summary>
        public string Status { get; set; }
    }
}