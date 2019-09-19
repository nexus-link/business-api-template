namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Bearing
{
    /// <summary>
    /// A Bearing Customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The Bearing Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The organization hint, the aggregated information of the customer. Name and organization numbers.
        /// </summary>
        public string OrganizationHint { get; set; }
    }
}
