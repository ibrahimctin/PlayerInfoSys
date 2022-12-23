using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlayerInfoSys.Domain.Application.Interfaces;
using PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries;
using PlayerInfoSys.Domain.DTOs.Requests.Club;
using PlayerInfoSys.Domain.DTOs.Requests.Player;

namespace PlayerInfoSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        [HttpPost("PlayerCreate")]
        public async Task<IActionResult> CreateClub(CreatePlayerRequest request)
        {
            var player = await _playerService.CreatePlayer(request);
            return Ok(player);
        }
        [HttpGet("GetAll")]

        public virtual async Task<IActionResult> GetAll([FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = new PaginationQuery(paginationQuery.PageNumber, paginationQuery.PageSize);
            var result = await _playerService.GetAll(pagination);
            return Ok(result);
        }
        [HttpGet("GetPlayerById")]
        public async Task<IActionResult> GetPlayerById(string id)
        {
            var player = await _playerService.GetPlayerById(id);
            return player is not null ? Ok(player) : NotFound();

        }
        [HttpDelete("DeletePlayer")]
        public async Task<IActionResult>DeletePlayer(string id)
        {
            var player = await _playerService.DeletePlayer(id);
            return Ok(player);
        }
        [HttpPost("PlayerUpdate")]
        public async Task<IActionResult> UpdatePlayer(UpdatePlayerRequest request)
        {
            var player = await _playerService.UpdatePlayer(request.Id);
            return Ok(player);
        }
    }
}
