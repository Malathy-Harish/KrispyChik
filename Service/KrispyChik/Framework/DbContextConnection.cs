using KrispyChik.Data_Access;
using KrispyChik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KrispyChik.Framework
{
    public static class DbContextConnection
    {
        public static IServiceCollection AddDbContextConnection(this IServiceCollection services)
        {
            services.AddDbContext<AppDataContext>(options =>
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KrispyChik;Integrated Security=True;"));

            return services;
        }
    }
}
