using ImdbIntegration.Application.Dtos;
using ImdbIntegration.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ImdbIntegration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchListsController : ControllerBase
    {
        private readonly IWatchListService watchListService;
        public WatchListsController(IWatchListService watchListService)
        {
            this.watchListService = watchListService;
        }

        [HttpGet("search/{expression}")]
        public async Task<IActionResult> GetByExpression(string expression)
        {
            return Ok(await watchListService.GetByExpressionAsync(expression));
        }

        [HttpGet("user/{userId:int}")]
        public async Task<IActionResult> GetUserWatchListById(int userId)
        {
            return Ok(await watchListService.GetUserWatchListByIdAsync(userId));
        }

        [HttpPatch("setstatus")]
        public async Task<IActionResult> SetStatus(WatchListItemDto watchListItem)
        {
            await watchListService.SetStatusAsync(watchListItem);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddToWatchList(WatchListItemDto watchListItem)
        {
            await watchListService.AddToWatchListAsync(watchListItem);
            return Ok();
        }
    }
}
