using KrispyChik.Model;
using Microsoft.EntityFrameworkCore;

namespace KrispyChik.Entities
{
    public class UserDb: DbContext
    {
        public UserDb(DbContextOptions<UserDb> options): base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
