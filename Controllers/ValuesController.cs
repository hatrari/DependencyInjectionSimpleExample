using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Services;

namespace DependencyInjection.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ValuesController : ControllerBase
  {
    [HttpGet]
    public ActionResult<string> Get(
      [FromServices] IPaymentService paymentService)
    {
      return paymentService.GetMessage();
    }
  }
}