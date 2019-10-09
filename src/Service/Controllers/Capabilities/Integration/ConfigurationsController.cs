using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Services.Contracts.Capabilities.Integration.AppSupport;
using Nexus.Link.Services.Controllers.Capabilities.Integration.AppSupport;
using Nexus.Link.Services.Controllers.Capabilities.Integration.BusinessEvents;

namespace AcmeCorp.BusinessApi.Service.Controllers.Capabilities.Integration
{
    /// <inheritdoc cref="BusinessEventsControllerBase" />
    [Route("api/Integration/v1/AppSupport/[controller]")]
    [ApiController]
    public class ConfigurationsController : ConfigurationsControllerBase
    {
        /// <inheritdoc />
        public ConfigurationsController(IAppSupportCapability capability) : base(capability)
        {
        }
    }
}