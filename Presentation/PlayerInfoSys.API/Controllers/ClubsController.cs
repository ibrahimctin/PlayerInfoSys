using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlayerInfoSys.Domain.Application.Interfaces;
using PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries;
using PlayerInfoSys.Domain.Common.Results.Paginations;
using PlayerInfoSys.Domain.DTOs.Requests.Club;
using System.Net;

namespace PlayerInfoSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private readonly IClubService _clubService;

        public ClubsController(IClubService clubService)
        {
            _clubService = clubService;
        }

        [HttpPost("CreateClub")]
        public async Task<IActionResult> CreateClub(CreateClubRequest request)
        {
            var club = await _clubService.CreateClubAsync(request);
            return Ok(club);
        }
        [HttpGet("GetClubById")]
        public async Task<IActionResult>GetClubById(string id)
        {
            var club = await _clubService.GetClubById(id);
            return club is null ? Ok(null) : Ok(club);
        }
        
        
    }
}
