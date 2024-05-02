using Microsoft.AspNetCore.Mvc;
using Ordering.Models;

namespace Ordering.Controllers
{
    [ApiController]
  [Route("[controller]")]
  public class OrderingController : ControllerBase
  {
    private readonly ILogger<OrderingController> _logger;

    public OrderingController(ILogger<OrderingController> logger)
    {
      _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> PlaceOrder(PlaceOrder order)
    { }
  }
}
