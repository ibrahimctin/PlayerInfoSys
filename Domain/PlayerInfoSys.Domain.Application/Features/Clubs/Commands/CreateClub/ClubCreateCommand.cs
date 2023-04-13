namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.CreateClub
{
    public sealed record ClubCreateCommand(CreateClubRequest CreateClubRequest) : IRequest<bool>
    {
        
    }
}
