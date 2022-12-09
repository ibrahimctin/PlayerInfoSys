using PlayerInfoSys.Domain.DbEntities.Base;

namespace PlayerInfoSys.Domain.DbEntities.Entities
{
    public class Player:BaseEntity<string>
    {
        public string Name { get; set; }
        public string Rumours { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Citizenship { get; set; }
        public string PlayerAgent { get; set; }
        public string Outfitter { get; set; }
        public string ClubId { get; set; }
        public Club Club { get; set; }
    }
}
