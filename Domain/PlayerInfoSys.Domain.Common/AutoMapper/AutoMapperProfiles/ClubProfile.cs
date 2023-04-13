namespace PlayerInfoSys.Domain.Common.AutoMapper.AutoMapperProfiles
{
    public class ClubProfile:Profile
    {
        public ClubProfile()
        {
            CreateMap<CreateClubRequest, Club>().ReverseMap();
            CreateMap<ClubDetailResponse, Club>().ReverseMap();

        }
    }
}
