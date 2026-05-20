using Microsoft.EntityFrameworkCore;

namespace Student_WebApp.Data
{
    public class AppDbContexts : DbContext
    {
        public AppDbContexts(DbContextOptions<AppDbContexts> options) : base(options) 
        {
            
        }

        public DbSet<Student_WebApp.Models.Students> Students { get; set; }
    }
}
