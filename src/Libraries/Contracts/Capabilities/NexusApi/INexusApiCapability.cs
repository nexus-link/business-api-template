using Nexus.Link.Libraries.Crud.Interfaces;
using Nexus.Link.Services.Contracts.Capabilities;

namespace AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.NexusApi
{
  /// <summary>
  /// The mandatory services for all Nexus Adapters
  /// </summary>
  public interface INexusApiCapability : IControllerInjector, ICrudable
  {
  }
}
