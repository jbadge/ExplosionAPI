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
    public class ExplosionController : ControllerBase
    {
        // Using URL
        [HttpGet("{s}")]
        public string Explosion(string s)
        {
            return string.Join("", s.Select(x => new String(x, int.Parse(x.ToString()))));
        }
    }
}
