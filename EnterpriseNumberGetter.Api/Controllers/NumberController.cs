using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EnterpriseNumberGetter.Core;

namespace EnterpriseNumberGetter.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NumberController : ControllerBase
    {
        [HttpPost]
        public string HandleNumberReceived([FromBody] NumberRequest numberRequest)
        {
   
            var inputHandler = new WebRequestInputHandler();
            var inputString = inputHandler.GetInput();
            return "string";
        }
    }
}
