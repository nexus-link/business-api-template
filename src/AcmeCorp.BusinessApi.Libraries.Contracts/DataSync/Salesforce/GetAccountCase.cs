namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Salesforce
{
    /// <summary>
    /// A Get Account Case
    /// </summary>
    public class GetAccountCase
    {
        /// <summary>
        /// The Salesforce Id
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// The account hint. Name and organization number information, helps user i salesfore to map case to an account.
        /// </summary>
        public string AccountHint { get; set; }

        /// <summary>
        /// The account id used for initially mapping contacts to an account.
        /// </summary>
        public string InitialAccountId { get; set; }
    }
}
