using Nexus.Link.Services.Contracts.Capabilities.Integration.AppSupport;
using Nexus.Link.Services.Contracts.Capabilities.Integration.Authentication;
using Nexus.Link.Services.Contracts.Capabilities.Integration.BusinessEvents;
using Nexus.Link.Services.Contracts.Events;
using Nexus.Link.Services.Controllers.Capabilities.Integration.AppSupport;
using Nexus.Link.Services.Controllers.Capabilities.Integration.Authentication;
using Nexus.Link.Services.Controllers.Capabilities.Integration.BusinessEvents;
using Nexus.Link.Services.Controllers.Events;
using Nexus.Link.Services.Implementations.Adapter.Startup;
using Nexus.Link.Services.Implementations.BusinessApi.Startup;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.NexusApi;

namespace AcmeCorp.BusinessApi.Libraries.Controllers
{
  /// <summary>
  /// Registers controllers for capabilities
  /// </summary>
  public static class StartupExtensions
  {
    /// <summary>
    /// Register all controllers for the business API
    /// </summary>
    /// <remarks>Typically the BusinessEventsCapability, which should not be in the adapters.</remarks>
    public static void RegisterCapabilityControllers(this NexusBusinessApiStartup startup)
    {
      startup.RegisterControllersForCapability<IAppSupportCapability>(
          typeof(NexusConfigurationsController));
      startup.RegisterControllersForCapability<IBusinessEventsCapability>(
          typeof(NexusBusinessEventsController));
      startup.RegisterControllersForCapability<IAuthenticationCapability>(
          typeof(NexusTokensController));
      RegisterCommonCapabilityControllers(startup);
    }

    /// <summary>
    /// Register all controllers for the adapters
    /// </summary>
    public static void RegisterCapabilityControllers(this NexusAdapterStartup startup)
    {
      RegisterCommonCapabilityControllers(startup);
    }

    private static void RegisterCommonCapabilityControllers(NexusCommonStartup startup)
    {
      // NexusApiCapability
      startup.RegisterControllersForCapability<INexusApiCapability>(
          typeof(NexusRootsController));

      // IEventReceiver
      startup.RegisterControllersForCapability<IEventReceiver>(
          typeof(NexusReceiveEventsController));
    }
  }
}
