using System;
using Nexus.Link.Services.Contracts.Events;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Events.CustomerEndUser
{
    /// <summary>
    /// This event is published when a service provisioning case has been completed.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class CustomerEndUser_CaseCompleted : IPublishableEvent
    {
        /// <inheritdoc />
        public EventMetadata Metadata { get; set; } = new EventMetadata("CustomerEndUser", "CaseCompleted", 1, 0);

        /// <summary>
        /// The id of the service provisioning case
        /// </summary>
        public string CustomerEndUserId { get; set; }

        /// <summary>
        /// The id of the case
        /// </summary>
        public string CaseId { get; set; }

        /// <summary>
        /// The time when the case was completed, in time zone UTC
        /// </summary>
        public DateTime CompletedAtUtcTime { get; set; }
    }
}
