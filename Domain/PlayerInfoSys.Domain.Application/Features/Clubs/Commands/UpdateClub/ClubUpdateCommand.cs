namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.UpdateClub
{
    public sealed record ClubUpdateCommand(UpdateClubRequest UpdateClubRequest) : ICommand<bool>
    {
    }
}
