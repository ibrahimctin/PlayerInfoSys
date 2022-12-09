using PlayerInfoSys.Domain.DbEntities.Entities;
using PlayerInfoSys.Infrastructure.Context;
using PlayerInfoSys.Infrastructure.Interfaces.Repositories;

namespace PlayerInfoSys.Infrastructure.Implementation.Repositories
{
    internal class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
