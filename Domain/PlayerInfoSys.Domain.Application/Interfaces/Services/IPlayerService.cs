using PlayerInfoSys.Domain.DTOs.Players.RequestPlayerDtos;
using PlayerInfoSys.Domain.DTOs.Players.ResponsePlayerDtos;

namespace PlayerInfoSys.Domain.Application.Interfaces.Services
{
    public interface IPlayerService
    {
        Task<bool> CreatePlayer(CreatePlayerRequest request);
        Task<IResult> GetAll(PaginationQuery query);
        Task<PlayerDetailResponse> GetPlayerById(string id);
        Task<bool> UpdatePlayer(string id);
        Task<bool> DeletePlayer(string id);

    }
}
