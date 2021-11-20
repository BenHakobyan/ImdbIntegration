using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbIntegration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {

        [HttpGet("search/{expression}")]
        public async Task<IActionResult> GetByExpression(string expression)
        {
            return Ok();
        }
    }
}
