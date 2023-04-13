using PlayerInfoSys.Domain.DTOs.Clubs.RequestClubDtos;
using PlayerInfoSys.Domain.DTOs.Clubs.ResponseClubDtos;

namespace PlayerInfoSys.Domain.Application.Interfaces.Services
{
    public interface IClubService
    {

        Task<bool> CreateClubAsync(CreateClubRequest request);
        Task<bool> DeleteClubAsync(string id);
        Task<ClubDetailResponse> GetClubById(string id);
        Task<bool> UpdateClub(UpdateClubRequest request);


    }
}
