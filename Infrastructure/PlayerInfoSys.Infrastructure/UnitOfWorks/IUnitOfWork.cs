namespace PlayerInfoSys.Infrastructure.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IClubRepository Club { get; }
        IPlayerRepository Player { get; }

        Task SaveAsync();
    }
}
