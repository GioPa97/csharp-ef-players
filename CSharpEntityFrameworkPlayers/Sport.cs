using Microsoft.EntityFrameworkCore;

namespace CSharpEntityFrameworkPlayers
{
    public class SchoolContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=MySportDb;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
