using System;
using Nexus.Link.Services.Contracts.Events;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Events.CustomerEndUser
{
    /// <summary>
    /// This event is published when a service has been provisioned.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class CustomerEndUser_ServiceProvisioned : IPublishableEvent
    {
        /// <inheritdoc />
        public EventMetadata Metadata { get; set; } = new EventMetadata("CustomerEndUser", "ServiceProvisioned", 1, 0);

        /// <summary>
        /// The id of the service provisioning case
        /// </summary>
        public string CustomerEndUserId { get; set; }

        /// <summary>
        /// The id of the service that has been provisioned
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// The time when the service was provisioned, in time zone UTC
        /// </summary>
        public DateTime ProvisionedAtUtcTime { get; set; }
    }
}
