namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.DeletePlayer
{
    public class PlayerDeleteCommandHandler : ICommandHandler<PlayerDeleteCommand, bool>
    {
        private readonly IPlayerService _playerService;

        public PlayerDeleteCommandHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<bool> Handle(PlayerDeleteCommand request, CancellationToken cancellationToken)
        {
            var deletedPlayer = await _playerService.DeletePlayer(request.Id);
            return deletedPlayer;
        }
    }
}
