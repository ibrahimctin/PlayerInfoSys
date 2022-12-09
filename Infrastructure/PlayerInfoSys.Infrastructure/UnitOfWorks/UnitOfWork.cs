using PlayerInfoSys.Infrastructure.Context;
using PlayerInfoSys.Infrastructure.Implementation.Repositories;
using PlayerInfoSys.Infrastructure.Interfaces.Repositories;

namespace PlayerInfoSys.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Lazy<IClubRepository> _clubRepository;
        private readonly Lazy<IPlayerRepository> _playerRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            _clubRepository = new Lazy<IClubRepository>(() => new ClubRepository(context));
            _playerRepository =new Lazy<IPlayerRepository>(() => new PlayerRepository(context));
        }
        public IClubRepository Club => _clubRepository.Value;

        public IPlayerRepository Player => _playerRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
