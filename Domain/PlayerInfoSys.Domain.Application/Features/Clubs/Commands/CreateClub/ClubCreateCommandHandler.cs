namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.CreateClub
{
    public class ClubCreateCommandHandler : IRequestHandler<ClubCreateCommand, bool>
    {
        private readonly IClubService _clubService;

        public ClubCreateCommandHandler(IClubService clubService)
        {
            _clubService = clubService;
        }

        public Task<bool> Handle(ClubCreateCommand request, CancellationToken cancellationToken)
        {
            var createdClub = _clubService.CreateClubAsync(request.CreateClubRequest);
            return createdClub;

        }
    }
}
