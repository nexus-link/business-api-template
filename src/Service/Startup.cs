using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nexus.Link.Libraries.Core.Application;
using Nexus.Link.Libraries.Core.Logging;
using Nexus.Link.Libraries.Web.AspNet.Authorize;
using Nexus.Link.Libraries.Web.Logging.Stackify;
using Nexus.Link.Libraries.Web.Pipe.Outbound;
using Nexus.Link.Services.Implementations.Adapter.Events;
using Nexus.Link.Services.Implementations.BusinessApi.Startup;
using Nexus.Link.Services.Implementations.BusinessApi.Startup.Configuration;
using AcmeCorp.BusinessApi.Libraries.Contracts.Capabilities.NexusApi;
using AcmeCorp.BusinessApi.Libraries.Controllers;
using AcmeCorp.BusinessApi.Libraries.Sdk.Capabilities.NexusApi;

namespace AcmeCorp.BusinessApi.Service
{
  internal class Startup : NexusBusinessApiStartup
  {
    private readonly string _stackifyKey;

    public Startup(IConfiguration configuration) : base(configuration)
    {
      _stackifyKey = configuration.GetMandatoryString("StackifyKey");
    }

    /// <inheritdoc />
    protected override ISyncLogger GetSynchronousFastLogger()
    {
      return FulcrumApplication.IsInDevelopment ? new DebugTraceLogger() : new StackifyLogger(_stackifyKey).AsQueuedSyncLogger().AsBatchLogger();
    }

    /// <inheritdoc />
    protected override void DependencyInjectServices(IServiceCollection services)
    {
      base.DependencyInjectServices(services);
      var httpClient = HttpClientFactory.Create(OutboundPipeFactory.CreateDelegatingHandlers());
      var serviceClientCredentials = GetLocalCredentials();

      //
      // Capabilities
      //

      // NexusApi
      services.AddScoped<INexusApiCapability>(p => new NexusApiCapability());

      // Register all controllers
      this.RegisterCapabilityControllers();
    }

    /// <inheritdoc />
    protected override void AddSubscriptions(EventSubscriptionHandler subscriptionHandler, IMvcBuilder mvcBuilder)
    {
      using (var serviceScope = mvcBuilder.Services.BuildServiceProvider().CreateScope())
      {
        var serviceProvider = serviceScope.ServiceProvider;
      }
    }

    /// <inheritdoc />
    protected override void SetMandatoryRole(IServiceCollection services)
    {
      MandatoryRoleRequirement.SetMandatoryRole("business-api-caller");
    }
  }
}
