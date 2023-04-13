namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.CreatePlayer
{
    public class PlayerCreateCommandHandler : ICommandHandler<PlayerCreateCommand, bool>
    {
        private readonly IPlayerService _playerService;

        public PlayerCreateCommandHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public Task<bool> Handle(PlayerCreateCommand request, CancellationToken cancellationToken)
        {
            var createdPlayer = _playerService.CreatePlayer(request.CreatePlayerRequest);
            return createdPlayer;
        }
    }
}
