using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Processes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkiController : ControllerBase
    {
        // GET: api/Ski
        [HttpGet("getskilength")]
        public string GetSkiLength([FromQuery] Skiier skiier)
        {
            return CalculateSkiLength.Calculate(skiier);
        }
    }
}
