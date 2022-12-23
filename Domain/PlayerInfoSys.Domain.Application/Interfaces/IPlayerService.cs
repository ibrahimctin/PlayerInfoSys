using PlayerInfoSys.Domain.Common.Results;
using PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries;
using PlayerInfoSys.Domain.DTOs.Requests.Player;
using PlayerInfoSys.Domain.DTOs.Responses.Player;

namespace PlayerInfoSys.Domain.Application.Interfaces
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
