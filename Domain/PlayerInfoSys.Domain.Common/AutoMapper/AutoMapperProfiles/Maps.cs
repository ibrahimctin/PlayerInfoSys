
using AutoMapper;
using PlayerInfoSys.Domain.DbEntities.Entities;
using PlayerInfoSys.Domain.DTOs.Requests.Club;
using PlayerInfoSys.Domain.DTOs.Requests.Player;
using PlayerInfoSys.Domain.DTOs.Responses.Club;
using PlayerInfoSys.Domain.DTOs.Responses.Player;

namespace PlayerInfoSys.Domain.Common.AutoMapper.AutoMapperProfiles
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<CreateClubRequest, Club>().ReverseMap();
            CreateMap<ClubDetailResponse, Club>().ReverseMap();

            CreateMap<CreatePlayerRequest, Player>().ReverseMap();
            CreateMap<PlayerDetailResponse,Player>().ReverseMap();
            
          
        }
    }
}
