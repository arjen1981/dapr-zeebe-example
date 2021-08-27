using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dapr_zeebe_example.Models;

namespace dapr_zeebe_example.Controllers
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
