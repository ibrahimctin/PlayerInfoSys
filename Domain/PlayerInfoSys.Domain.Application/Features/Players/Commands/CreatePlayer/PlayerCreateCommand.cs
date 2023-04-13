using PlayerInfoSys.Domain.DTOs.Players.RequestPlayerDtos;

namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.CreatePlayer
{
    public sealed record class PlayerCreateCommand(CreatePlayerRequest CreatePlayerRequest)
        : ICommand<bool>
    {
    }
}