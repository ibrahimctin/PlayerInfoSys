namespace PlayerInfoSys.Domain.Common.AutoMapper.AutoMapperProfiles
{
    public class PlayerProfile:Profile
    {
        public PlayerProfile()
        {
            CreateMap<CreatePlayerRequest, Player>().ReverseMap();
            CreateMap<UpdatePlayerRequest, Player>().ReverseMap();
            CreateMap<PlayerDetailResponse, Player>().ReverseMap();
        }
    }
}
