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
    public class MumblingController : ControllerBase
    {
        // Using Query
        [HttpGet]
        public string Mumbling(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new String(char.ToLower(x), i)));
        }
    }
}
