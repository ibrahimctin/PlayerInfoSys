using PlayerInfoSys.Domain.DTOs.Clubs.ResponseClubDtos;

namespace PlayerInfoSys.Domain.Application.Features.Clubs.Queries.GetClubDetails
{
    public class GetClubDetailsQueryHandler : IQueryHandler<GetClubDetailsQuery, ClubDetailResponse>
    {
        private readonly IClubService _clubService;

        public GetClubDetailsQueryHandler(IClubService clubService)
        {
            _clubService = clubService;
        }

        public async Task<ClubDetailResponse> Handle(GetClubDetailsQuery request, CancellationToken cancellationToken)
        {
             var clubDetailQuery = await _clubService.GetClubById(request.Id);
             return clubDetailQuery;
        }
    }
}
