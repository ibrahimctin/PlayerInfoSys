using PlayerInfoSys.Domain.DTOs.Clubs.ResponseClubDtos;

namespace PlayerInfoSys.Domain.Application.Features.Clubs.Queries.GetClubDetails
{
    public sealed record GetClubDetailsQuery(string Id):IQuery<ClubDetailResponse>
    {
    }
}
