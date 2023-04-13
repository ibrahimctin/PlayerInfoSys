namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.UpdateClub
{
    public class ClubUpdateCommandHandler : IRequestHandler<ClubUpdateCommand, bool>
    {
        private readonly IClubService _clubService;

        public ClubUpdateCommandHandler(IClubService clubService)
        {
            _clubService = clubService;
        }

        public Task<bool> Handle(ClubUpdateCommand request, CancellationToken cancellationToken)
        {
            var updatedClub = _clubService.UpdateClub(request.UpdateClubRequest);
            return updatedClub;
        }
    }
}
