﻿namespace PlayerInfoSys.Domain.DTOs.Players.RequestPlayerDtos
{
    public class CreatePlayerRequest
    {
        public string Name { get; set; }
        public string Rumours { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Citizenship { get; set; }
        public string PlayerAgent { get; set; }
        public string Outfitter { get; set; }

        public string ClubId { get; set; }
        [JsonIgnore]
        public ClubDetailResponse? Club { get; set; }
    }
}
