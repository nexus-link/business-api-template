using Nexus.Link.Libraries.Crud.Interfaces;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning.Model;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.ServiceProvisioning
{
    /// <summary>
    /// Service for invoices
    /// </summary>
    public interface ICaseService : ICreate<CaseCreate, Case, string>, IRead<Case, string>, IUpdate<Case, string>
    {
    }
}
