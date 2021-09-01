using EFCoreMigration.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMigration
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}