using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ValuesController : ControllerBase
  {
    public string Get()
    {
      return string.Empty;
    }
  }
}