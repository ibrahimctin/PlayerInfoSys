using PlayerInfoSys.Domain.DTOs.Players.ResponsePlayerDtos;

namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.Queries.GetPlayerDetails
{
    public sealed record GetPlayerDetailQuery(string Id)
        :IQuery<PlayerDetailResponse>
    {
    }
}
