using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nexus.Link.Libraries.Core.Application;
using Nexus.Link.Libraries.Core.Logging;
using Nexus.Link.Libraries.Web.AspNet.Authorize;
using Nexus.Link.Libraries.Web.Logging.Stackify;
using Nexus.Link.Libraries.Web.Pipe.Outbound;
using Nexus.Link.Services.Implementations.BusinessApi.Startup;
using Nexus.Link.Services.Implementations.BusinessApi.Startup.Configuration;

namespace AcmeCorp.BusinessApi.Service
{
  internal class Startup : NexusBusinessApiStartup
  {
    private readonly string _stackifyKey;
    private readonly string _serviceProvisioningCaseManagementUrl;

    public Startup(IConfiguration configuration) : base(configuration)
    {
      _serviceProvisioningCaseManagementUrl = configuration.GetMandatoryString("CapabilityEndpoints:ServiceProvisioningCaseManagement");
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

      //
      // Adapter services 
      //
      var httpClient = HttpClientFactory.Create(OutboundPipeFactory.CreateDelegatingHandlers());
    }

    /// <inheritdoc />
    protected override void SetMandatoryRole(IServiceCollection services)
    {
      MandatoryRoleRequirement.SetMandatoryRole("business-api-caller");
    }
  }
}
