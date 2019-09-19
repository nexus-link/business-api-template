namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Salesforce
{
    /// <summary>
    /// A Salesforce Contact
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// The Salesforce Id
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
        /// The phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// The <see cref="GetAccountCase"/> object that this Contact initially belongs to
        /// </summary>
        public string GetAccountCaseId { get; set; }
    }
}
