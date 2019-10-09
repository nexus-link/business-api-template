using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Services.Controllers.Capabilities.Api;

namespace AcmeCorp.BusinessApi.Libraries.Controllers.Capabilities.Api
{
  /// <summary>
  /// Service implementation of <see cref="IRootService"/>
  /// </summary>
  [Route("")]
  [ApiExplorerSettings(IgnoreApi = true)]
  public abstract class RootsControllerBase : Nexus.Link.Services.Controllers.Capabilities.Api.RootsControllerBase
  {
  }
}
