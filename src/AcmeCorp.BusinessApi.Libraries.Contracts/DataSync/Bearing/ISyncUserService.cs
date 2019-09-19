using Nexus.Link.Services.Contracts.DataSync;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Bearing
{
    /// <summary>
    /// The methods required to sync a Bearing <see cref="User"/>.
    /// </summary>
    public interface ISyncUserService : IDataSyncReadUpdate<User>
    {
    }
}
