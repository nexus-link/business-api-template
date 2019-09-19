using Nexus.Link.Libraries.Core.Storage.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning.Model
{

    /// <summary>
    /// Data type for service provisioning cases
    /// </summary>
    public class Case : CaseCreate, IUniquelyIdentifiable<string>
    {
        /// <inheritdoc />
        public string Id { get; set; }
    }

    /// <summary>
    /// Data type for service provisioning cases
    /// </summary>
    public class CaseCreate
    {
        /// <summary>
        /// The id of the EndUser
        /// </summary>
        public string EndUserId { get; set; }

        /// <summary>
        /// The title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        public string Description { get; set; }
    }
}