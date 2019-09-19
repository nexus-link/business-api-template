using System;
using Nexus.Link.Services.Contracts.Events;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Events.CustomerEndUser
{
    /// <summary>
    /// This event is published when a service package has been provisioned.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class CustomerEndUser_ServicePackageProvisioned : IPublishableEvent
    {
        /// <inheritdoc />
        public EventMetadata Metadata { get; set; } = new EventMetadata("CustomerEndUser", "ServicePackageProvisioned", 1, 0);

        /// <summary>
        /// The id of the service provisioning case
        /// </summary>
        public string CustomerEndUserId { get; set; }

        /// <summary>
        /// The id of the service that has been provisioned
        /// </summary>
        public string ServicePackageId { get; set; }

        /// <summary>
        /// The time when the service package was provisioned, in time zone UTC
        /// </summary>
        public DateTime ProvisionedAtUtcTime { get; set; }
    }
}
