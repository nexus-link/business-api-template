using Nexus.Link.Services.Contracts.DataSync;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.DataSync.Salesforce
{
    /// <summary>
    /// The methods required to sync a Salesforce <see cref="Contact"/>.
    /// </summary>
    public interface ISyncContactService : IDataSyncCreate<Contact>, IDataSyncReadUpdate<Contact>
    {
    }
}
