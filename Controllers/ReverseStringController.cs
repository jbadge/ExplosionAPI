using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        // Using URL
        [HttpGet("{s}")]
        public string ReverseString(string s)
        {
            return new String(s.ToArray().Reverse().ToArray());
        }
    }
}
