using ImdbIntegration.Application.Dtos;
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
    public class WatchListsController : ControllerBase
    {
        [HttpGet("user/{userId:int}")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            return Ok();
        }

        [HttpPatch("setstatus")]
        public async Task<IActionResult> SetStatus(WatchListItemDto watchListItem)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddToWatchList(WatchListItemDto watchListItem)
        {
            return Ok();
        }
    }
}
