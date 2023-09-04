using AspNetCoreAPI_V1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAPI_V1.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
