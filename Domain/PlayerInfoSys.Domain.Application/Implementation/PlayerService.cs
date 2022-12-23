using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlayerInfoSys.Domain.Application.Interfaces;
using PlayerInfoSys.Domain.Common.Results;
using PlayerInfoSys.Domain.Common.Results.Paginations;
using PlayerInfoSys.Domain.Common.Results.Paginations.PagingQueries;
using PlayerInfoSys.Domain.Common.UriService;
using PlayerInfoSys.Domain.DbEntities.Entities;
using PlayerInfoSys.Domain.DTOs.Requests.Player;
using PlayerInfoSys.Domain.DTOs.Responses.Club;
using PlayerInfoSys.Domain.DTOs.Responses.Player;
using PlayerInfoSys.Infrastructure.UnitOfWorks;

namespace PlayerInfoSys.Domain.Application.Implementation
{
    internal class PlayerService:IPlayerService
    {
        private readonly IUnitOfWork _uOw;
        private readonly IMapper _mapper;
        private readonly IPaginationUriService _uriSerivce;
      

        public PlayerService(IUnitOfWork uOw, IMapper mapper, IPaginationUriService uriSerivce)
        {
            _uOw = uOw;
            _mapper = mapper;
            _uriSerivce = uriSerivce;
          
        }

        #region CRUD 
        public async Task<bool> CreatePlayer(CreatePlayerRequest request)
        {
            var playerPayload = _mapper.Map<Player>(request);

            playerPayload.Club = await GetTeamDeatail(request.ClubId);

            if (playerPayload is not null)
            {
                await _uOw.Player.CreateAsync(playerPayload);


                await _uOw.SaveAsync();

            }

            return playerPayload is null ? false : true;

        }

        public async Task<IResult> GetAll(PaginationQuery query)
        {
            var data = _uOw.Player.GetPaging(null, query);


            if (data is null)
            {
                return new Result(System.Net.HttpStatusCode.NotFound, "NOT FOUND");
            }
            var list = await data.ToListAsync();

            var count = await data.CountAsync();

            return PaginationExtensions.CreatePaginationResult(list, System.Net.HttpStatusCode.OK, query, count, _uriSerivce);
        }

        public async Task<PlayerDetailResponse> GetPlayerById(string id)
        {
            var playerFromDb = GetPlayerDetail(id);
            var playerPayload = _mapper.Map<PlayerDetailResponse>(playerFromDb);
            if (playerFromDb is not null)
            {

                playerPayload.Club = _mapper.Map<ClubDetailResponse>(await GetTeamDeatail(playerPayload.ClubId));
            }

            return playerPayload is null ? playerPayload : null;
        }
        public async Task<bool> DeletePlayer(string id)
        {
            var playerFromDb = await GetPlayerDetail(id);

            var playerPayload = _mapper.Map<Player>(playerFromDb);
            if (playerFromDb is not null)
            {

                await _uOw.Player.DeleteAsync(playerPayload);
                await _uOw.SaveAsync();
            }

            return playerPayload is null ? false : true;


        }


        public async Task<bool> UpdatePlayer(string id)
        {
            var playerFromDb = await GetPlayerDetail(id);

            var playerPayload = _mapper.Map<Player>(playerFromDb);
            if (playerFromDb is not null)
            {

                await  _uOw.Player.UpdateAsync(playerPayload);
                await  _uOw.SaveAsync();
            }

            return playerPayload is null ? false : true;
        }
        #endregion




        #region Private methods

        private async Task<Club> GetTeamDeatail(string teamId) => await _uOw.Club.GetWhere(x=>x.Id==teamId);
        private async Task<Player> GetPlayerDetail(string id) => await _uOw.Player.GetWhere(x => x.Id == id);

     


        #endregion
    }
}
