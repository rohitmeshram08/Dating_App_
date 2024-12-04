
using Dating_app_1.Entities;
using Microsoft.EntityFrameworkCore;
namespace Dating_app_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<App_User> AppUsers { get; set; }
    }
}
