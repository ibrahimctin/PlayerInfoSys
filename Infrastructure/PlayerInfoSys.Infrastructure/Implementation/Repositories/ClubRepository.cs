namespace PlayerInfoSys.Infrastructure.Implementation.Repositories
{
    internal class ClubRepository : Repository<Club>, IClubRepository
    {
        public ClubRepository(AppDbContext context) : base(context)
        {
        }
    }
}
