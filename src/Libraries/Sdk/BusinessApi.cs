using Nexus.Link.Libraries.Core.Platform.Authentication;
using Nexus.Link.Services.Contracts.Capabilities.Integration;

namespace AcmeCorp.BusinessApi.Libraries.Sdk
{
  /// <summary>
  /// Singleton class to access functionality in the Business API.
  /// </summary>
  public static class BusinessApi
  {
    /// <summary>
    /// Initialize this singleton
    /// </summary>
    public static void Initialize(string endpoint, AuthenticationCredentials credentials)
    {
      CapabilityImplementations.InitializeSingleton(endpoint, credentials);
    }

    /// <summary>
    /// Access to the Business API <see cref="IIntegrationCapability"/> implementation.
    /// </summary>
    public static IIntegrationCapability Integration => CapabilityImplementations.Instance.Integration;
  }
}
