using Microsoft.EntityFrameworkCore;

namespace CreateDBFromScratch.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Students> Students { get; set; }

        public SchoolContext(DbContextOptions options) :base(options) 
        {
            
        }
    }
}
