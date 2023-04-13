namespace PlayerInfoSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlayersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(PlayerCreateCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(Post), new { id = response });
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(PlayerUpdateCommand request)
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
            var command = new PlayerDeleteCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerDetailResponse>> Get(string id)
        {
            var leaveRequest = await _mediator.Send(new GetClubDetailsQuery(id));
            return Ok(leaveRequest);
        }
    }
}
