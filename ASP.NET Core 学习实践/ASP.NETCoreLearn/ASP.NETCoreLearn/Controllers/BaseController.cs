using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreLearn.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        ILogger _logger;
        public BaseController(ILogger logger)
        {
            _logger = logger;
        }
        [HttpGet("getTime")]
        public ActionResult getTime(string deviceNo, int deviceType = 1, string transactionId = "", int taskType = 0)
        {
            _logger.LogError("This is getTime");
            return new JsonResult(DateTime.Now.ToString());
        }
    }
}
