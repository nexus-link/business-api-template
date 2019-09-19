using System;
using Nexus.Link.Services.Contracts.Events;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Events.CustomerEndUser
{
    /// <summary>
    /// This event is published when a sales order has been accepted.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class CustomerEndUser_SalesOrderAccepted : IPublishableEvent
    {
        /// <inheritdoc />
        public EventMetadata Metadata { get; set; } = new EventMetadata("CustomerEndUser", "SalesOrderAccepted", 1, 0);

        /// <summary>
        /// The id of the service provisioning case
        /// </summary>
        public string CustomerEndUserId { get; set; }

        /// <summary>
        /// The id of the case
        /// </summary>
        public string SalesOrderId { get; set; }

        /// <summary>
        /// The time when the case was completed, in time zone UTC
        /// </summary>
        public DateTime AcceptedAtUtcTime { get; set; }
    }
}
