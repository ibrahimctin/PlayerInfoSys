using PlayerInfoSys.Domain.DbEntities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
