using PlayerInfoSys.Domain.DTOs.Players.RequestPlayerDtos;

namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.UpdatePlayer
{
    public sealed record PlayerUpdateCommand(UpdatePlayerRequest UpdatePlayerRequest)
        : ICommand<bool>
    {
    }
}
