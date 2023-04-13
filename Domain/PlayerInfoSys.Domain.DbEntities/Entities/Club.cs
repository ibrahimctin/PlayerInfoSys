using PlayerInfoSys.Domain.DbEntities.Base;

namespace PlayerInfoSys.Domain.DbEntities.Entities
{
    public class Club:BaseEntity<string>
    {
        
        public string Name { get; set; }
        public string Country { get; set; }
        public string? PlayerId { get; set; }
        public ICollection<Player> Players { get; set; }

    }
}
