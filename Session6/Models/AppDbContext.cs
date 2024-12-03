using Microsoft.EntityFrameworkCore;

namespace Session6.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = .; Database = Session6 ; trustservercertificate = true ; integrated security = SSPI");
        }
    }
}
