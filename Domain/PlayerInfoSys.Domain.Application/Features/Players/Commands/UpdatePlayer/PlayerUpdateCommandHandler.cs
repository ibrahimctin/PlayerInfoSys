namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.UpdatePlayer
{
    public class PlayerUpdateCommandHandler : ICommandHandler<PlayerUpdateCommand, bool>
    {
        private readonly IPlayerService _playerService;

        public PlayerUpdateCommandHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<bool> Handle(PlayerUpdateCommand request, CancellationToken cancellationToken)
        {
            var updatedPlayer = _playerService.UpdatePlayer(request.UpdatePlayerRequest.Id);
            return updatedPlayer != null;
        }
    }
}
