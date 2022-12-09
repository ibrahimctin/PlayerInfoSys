using PlayerInfoSys.Domain.DbEntities.Entities;
using PlayerInfoSys.Infrastructure.Context;
using PlayerInfoSys.Infrastructure.Interfaces.Repositories;

namespace PlayerInfoSys.Infrastructure.Implementation.Repositories
{
    internal class ClubRepository : Repository<Club>, IClubRepository
    {
        public ClubRepository(AppDbContext context) : base(context)
        {
        }
    }
}
