namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.DeleteClub
{
    public class ClubDeleteCommandHandler : IRequestHandler<ClubDeleteCommand, bool>
    {
        private readonly IClubService _clubService;

        public ClubDeleteCommandHandler(IClubService clubService)
        {
            _clubService = clubService;
        }

        public async Task<bool> Handle(ClubDeleteCommand request, CancellationToken cancellationToken)
        {
            var deletedClub = await _clubService.DeleteClubAsync(request.Id);
            return deletedClub;
        }
    }
}
