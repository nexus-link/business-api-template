using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nexus.Link.Authentication.AspNet.Sdk.Handlers;
using Nexus.Link.Libraries.Core.Application;
using Nexus.Link.Libraries.Core.Logging;
using Nexus.Link.Libraries.Core.Threads;
using Nexus.Link.Libraries.Web.AspNet.Authorize;
using Nexus.Link.Libraries.Web.Logging.Stackify;
using Nexus.Link.Services.Contracts.Events;
using Nexus.Link.Services.Implementations.Adapter.Startup;
using Nexus.Link.Services.Implementations.BusinessApi.Startup.Configuration;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.NexusApi;
using AcmeCorp.BusinessApi.Libraries.Controllers;
using AcmeCorp.BusinessApi.Libraries.Sdk.Capabilities.NexusApi;

namespace AcmeCorp.BusinessApi.Libraries.Sdk.Startup
{
  /// <summary>
  /// Helper class for the different steps in the Startup.cs file.
  /// </summary>
  public abstract class AdapterStartup : NexusAdapterStartup
  {
    /// <summary>
    /// Use this constructor in the Startup constructor.
    /// </summary>
    /// <param name="configuration">Take this from the Startup constructor.</param>
    protected AdapterStartup(IConfiguration configuration) : base(configuration)
    {
      BusinessApi.Initialize(AdapterConfiguration.BusinessApiEndpoint, AdapterConfiguration.BusinessApiCredentials);
      EventExtensions.BusinessEventService = BusinessApi.Integration.BusinessEvents.BusinessEventService;
    }

    /// <inheritdoc />
    protected override ISyncLogger GetSynchronousFastLogger()
    {
      return FulcrumApplication.IsInDevelopment ? new DebugTraceLogger() : new StackifyLogger(Configuration.GetMandatoryString("StackifyKey")).AsQueuedSyncLogger().AsBatchLogger();
    }

    /// <inheritdoc />
    protected override void DependencyInjectBusinessApiServices(IServiceCollection services)
    {
      // Inject the Business API SDK
      services.AddSingleton(p => BusinessApi.Integration);

      services.AddScoped<INexusApiCapability, NexusApiCapability>();

      this.RegisterCapabilityControllers();
    }

    /// <inheritdoc />
    protected override void SetMandatoryRole(IServiceCollection services)
    {
      MandatoryRoleRequirement.SetMandatoryRole("adapter-caller");
    }

    /// <inheritdoc />
    protected override void ConfigureAppMiddleware(IApplicationBuilder app, IHostingEnvironment env)
    {
      base.ConfigureAppMiddleware(app, env);
      if (FulcrumApplication.IsInDevelopment) return;
      // Verify tokens with our public key
      var rsaPublicKey = ThreadHelper.CallAsyncFromSync(BusinessApi.Integration.Authentication.TokenService
          .GetPublicRsaKeyAsXmlAsync);
      app.UseNexusTokenValidationHandler(rsaPublicKey);
    }
  }
}
