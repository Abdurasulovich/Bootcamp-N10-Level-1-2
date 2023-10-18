using MatchBoardService.Api.Models.Entities;
using MatchBoardService.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchBoardService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMatchesController : ControllerBase
    {
        private readonly MatchService _matchService;

        public TeamMatchesController(MatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateMatch([FromBody] TeamMatch match)
        {
            var createMatch = await _matchService.CreateAsync(match);
            return Ok(createMatch);
        }
    }
}
