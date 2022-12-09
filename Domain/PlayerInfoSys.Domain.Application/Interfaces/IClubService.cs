using PlayerInfoSys.Domain.Common.Results;
using PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries;
using PlayerInfoSys.Domain.DTOs.Requests.Club;
using PlayerInfoSys.Domain.DTOs.Responses.Club;

namespace PlayerInfoSys.Domain.Application.Interfaces
{
    public interface IClubService
    {

        Task<bool> CreateClubAsync(CreateClubRequest request);
        Task<bool> DeleteClubAsync(string id);
        Task<ClubDetailResponse> GetClubById(string id);
        

    }
}
