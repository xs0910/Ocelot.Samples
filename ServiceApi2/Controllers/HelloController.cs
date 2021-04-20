using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Content($"Hello ServiceApi2----{Request.HttpContext.Connection.LocalPort}");
        }
    }
}
