using Microsoft.EntityFrameworkCore;

namespace StateManagementUsingDatabase.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
