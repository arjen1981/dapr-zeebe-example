using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Zeebe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoSomethingController : ControllerBase
    {
        private readonly ILogger<DoSomethingController> _logger;

        public DoSomethingController(ILogger<DoSomethingController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/dosomething")]
        public void DoSomething()
        {
            _logger.LogInformation("DoSomething triggered");
        }
    }
}
