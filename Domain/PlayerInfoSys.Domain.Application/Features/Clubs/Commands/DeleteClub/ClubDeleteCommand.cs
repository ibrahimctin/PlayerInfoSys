namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.DeleteClub
{
    public sealed record ClubDeleteCommand(string Id) : IRequest<bool>
    {

    }
}
