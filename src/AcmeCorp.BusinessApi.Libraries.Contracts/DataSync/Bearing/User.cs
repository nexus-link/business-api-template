namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Bearing
{
    /// <summary>
    /// A Bearing User
    /// </summary>
    public class User
    {
        /// <summary>
        /// The Bearing Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The end user phone number
        /// </summary>
        public string EndUserPhoneNumber { get; set; }

        /// <summary>
        /// The subscription phone number
        /// </summary>
        public string SubscriptionPhoneNumber { get; set; }

        /// <summary>
        /// The <see cref="Customer"/> object that this User belongs to
        /// </summary>
        public string CustomerId { get; set; }
    }
}
