using AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Bearing;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Salesforce
{
    /// <summary>
    /// All sync services for Salesforce
    /// </summary>
    public interface ISalesforceDataSync
    {
        /// <summary>
        /// The <see cref="ISyncCustomerService"/>
        /// </summary>
        ISyncGetAccountCaseService SyncGetAccountCaseService { get; }

        /// <summary>
        /// The <see cref="ISyncUserService"/>
        /// </summary>
        ISyncContactService SyncContactService { get; }
    }
}
