using Microsoft.EntityFrameworkCore;

namespace HelloEFCore
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=comment;user=test;password=123456");
        }
    }
}