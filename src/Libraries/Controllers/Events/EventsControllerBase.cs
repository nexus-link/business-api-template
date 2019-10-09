using Microsoft.AspNetCore.Mvc;
using Nexus.Link.Services.Contracts.Events;


namespace AcmeCorp.BusinessApi.Libraries.Controllers.Events
{
  /// <summary>
  /// Service implementation of <see cref="IEventReceiver"/>
  /// </summary>
  [Route("")]
  public abstract class EventsControllerBase : Nexus.Link.Services.Controllers.Events.EventsControllerBase
  {
    /// <inheritdoc />
    protected EventsControllerBase(IEventReceiver logic) : base(logic)
    {
    }
  }
}
