using PlayerInfoSys.Domain.Application.Features.Clubs.Queries.GetClubDetails;
using PlayerInfoSys.Domain.DTOs.Clubs.ResponseClubDtos;

namespace PlayerInfoSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClubsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(ClubCreateCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(Post), new { id = response });
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(ClubUpdateCommand request)
        {
            await _mediator.Send(request);
            return NoContent();
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(string id)
        {
            var command = new ClubDeleteCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ClubDetailResponse>> Get(string id)
        {
            var leaveRequest = await _mediator.Send(new GetClubDetailsQuery(id));
            return Ok(leaveRequest);
        }
    }
}
