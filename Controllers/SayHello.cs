using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SaqaSMC_2_SayHello.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloApi : ControllerBase
    {
        [HttpGet("Hello/{name}")]
        public string SayHello(string name)
        {
            return $"Hello, {name}.";

        }
    }
}