using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Services;

namespace DependencyInjection.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ValuesController : ControllerBase
  {
    private readonly IPaymentService paymentService;
    
    public ValuesController(IPaymentService paymentService)
    {
      this.paymentService = paymentService;
    }

    public string Get()
    {
      return paymentService.GetMessage();
    }
  }
}