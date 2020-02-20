using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Interface;

namespace WebApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITest _test;
        public TestController(ITest test)
        {
            _test = test;
        }

        [HttpPost]
        public ActionResult Test([FromBody]string msg)
        {
            return Ok(_test.Test(msg));
        }
    }
}