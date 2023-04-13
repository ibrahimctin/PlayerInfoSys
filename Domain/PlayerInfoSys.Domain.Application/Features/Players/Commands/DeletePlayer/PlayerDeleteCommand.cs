namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.DeletePlayer
{
    public sealed record PlayerDeleteCommand(string Id) :
        ICommand<bool>
    {
    }
}
