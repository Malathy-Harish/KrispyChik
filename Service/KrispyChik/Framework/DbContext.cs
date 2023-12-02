using KrispyChik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KrispyChik.Framework
{
    public static class DbContext
    {
        public static IServiceCollection AddDbContextConnection(this IServiceCollection services)
        {
            services.AddDbContext<UserDb>(options =>
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KrispyChik;Integrated Security=True;"));

            return services;
        }
    }
}
