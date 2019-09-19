namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Bearing
{
    /// <summary>
    /// All sync services for Bearing
    /// </summary>
    public interface IBearingDataSync
    {
        /// <summary>
        /// The <see cref="ISyncCustomerService"/>
        /// </summary>
        ISyncCustomerService SyncCustomerService { get; }

        /// <summary>
        /// The <see cref="ISyncUserService"/>
        /// </summary>
        ISyncUserService SyncUserService { get; }
    }
}
