namespace PlayerInfoSys.Infrastructure.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)   
        {

        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Player>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            builder.Entity<Club>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
          
        }
    }
}
