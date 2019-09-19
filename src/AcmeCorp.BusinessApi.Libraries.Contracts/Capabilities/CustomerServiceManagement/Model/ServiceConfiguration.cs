using Nexus.Link.Libraries.Core.Storage.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.CustomerServiceManagement.Model
{
    /// <summary>
    /// Data type for a service package configuration
    /// </summary>
    public class ServiceConfiguration : IUniquelyIdentifiable<string>
    {
        /// <summary>
        /// The id of service package configuration
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The id of customer
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// The id of the customer end user
        /// </summary>
        public string CustomerEndUserId { get; set; }
    }
}