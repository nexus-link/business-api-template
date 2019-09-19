using System;
using Nexus.Link.Services.Contracts.Events;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Events.CustomerEndUser
{
    /// <summary>
    /// This event is published when the customer end user is considered onboarded.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class CustomerEndUser_Onboarded : IPublishableEvent
    {
        /// <inheritdoc />
        public EventMetadata Metadata { get; set; } = new EventMetadata("CustomerEndUser", "Onboarded", 1, 0);

        /// <summary>
        /// The id of the service provisioning case
        /// </summary>
        public string CustomerEndUserId { get; set; }

        /// <summary>
        /// The time when the customer end user was considered onboarded, in time zone UTC
        /// </summary>
        public DateTime OnboardedAtUtcTime { get; set; }
    }
}
