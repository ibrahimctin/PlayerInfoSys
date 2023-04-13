using PlayerInfoSys.Domain.DTOs.Players.ResponsePlayerDtos;

namespace PlayerInfoSys.Domain.Application.Features.Players.Queries.GetPlayerDetails
{
    public class GetPlayerDetailQueryHandler : IQueryHandler<GetPlayerDetailQuery, PlayerDetailResponse>
    {
        private readonly IPlayerService _playerService;

        public GetPlayerDetailQueryHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<PlayerDetailResponse> Handle(GetPlayerDetailQuery request, CancellationToken cancellationToken)
        {
            var playerDetailQuery = await _playerService.GetPlayerById(request.Id);
            return playerDetailQuery;
        }
    }
}
