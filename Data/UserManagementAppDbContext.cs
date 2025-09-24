public class UserManagementAppDbContext : DbContext
{
    public UserManagementAppDbContext(DbContextOptions<UserManagementAppDbContext> options) : base(options) { }
    public DbSet<User> Users => Set<User>();
    public DbSet<University> Universities => Set<University>();
    public DbSet<Campus> Campuses => Set<Campus>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed universities and campuses
    }
}
