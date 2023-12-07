using KrispyChik.Entities;
using KrispyChik.Model;
using Microsoft.EntityFrameworkCore;

namespace KrispyChik.Data_Access
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Auth> Auths { get; set; }
    }
}
