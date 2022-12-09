﻿    using AutoMapper;
using PlayerInfoSys.Domain.Application.Interfaces;
using PlayerInfoSys.Domain.DbEntities.Entities;
using PlayerInfoSys.Domain.DTOs.Requests.Club;
using PlayerInfoSys.Domain.DTOs.Responses.Club;
using PlayerInfoSys.Infrastructure.UnitOfWorks;

namespace PlayerInfoSys.Domain.Application.Implementation
{
    internal class ClubService : IClubService
    {
        private readonly IUnitOfWork _uOw;
        private readonly IMapper _mapper;
        public ClubService(IUnitOfWork uOw, IMapper mapper)
        {
            _uOw = uOw;
            _mapper = mapper;
        }




        public async Task<bool> CreateClubAsync(CreateClubRequest request)
        {
            var clubPayload = _mapper.Map<Club>(request);
            if (clubPayload is not null)
            {
                await _uOw.Club.CreateAsync(clubPayload);
                await _uOw.SaveAsync();
            }
            return clubPayload is null ? false : true;

        }

        public async Task<bool> DeleteClubAsync(string id)
        {
            var clubFromDb =  await GetClubDetail(id);
            var clubPayload = _mapper.Map<ClubDetailResponse>(clubFromDb);
            if (clubFromDb is not null)
            {
               
                await _uOw.Club.UpdateAsync(clubFromDb);
                await _uOw.SaveAsync();
            }
           
            return clubPayload is null ? false : true;

        }

        public async Task<ClubDetailResponse> GetClubById(string id)
        {
            var clubFromDb = await GetClubDetail(id);
            return _mapper.Map<ClubDetailResponse>(clubFromDb);
        }




        #region Private Methods

        private async Task<Club> GetClubDetail(string id) => await _uOw.Club.GetWhere(c => c.Id == id);


        #endregion
    }
}
