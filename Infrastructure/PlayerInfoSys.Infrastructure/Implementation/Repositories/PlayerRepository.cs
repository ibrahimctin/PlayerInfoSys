namespace PlayerInfoSys.Infrastructure.Implementation.Repositories
{
    internal class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
