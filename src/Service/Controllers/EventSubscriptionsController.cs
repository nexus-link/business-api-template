using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Nexus.Link.Services.Contracts.Events;

namespace AcmeCorp.BusinessApi.Service.Controllers
{
  /// <inheritdoc/>
  public class EventSubscriptionsController : IEventReceiver
  {
    private readonly IEventReceiver _logic;

    /// <inheritdoc/>
    public EventSubscriptionsController(IEventReceiver logic)
    {
      _logic = logic;
    }
    /// <inheritdoc/>
    public Task ReceiveEvent(JToken eventAsJson, CancellationToken token = default)
    {
      return _logic.ReceiveEvent(eventAsJson, token);
    }
  }
}
