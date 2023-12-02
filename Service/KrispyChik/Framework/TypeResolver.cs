using KrispyChik.Business_Contracts;
using KrispyChik.Business_Manager;
using KrispyChik.Data_Access;
using KrispyChik.Data_Contracts;

namespace KrispyChik.Framework
{
    public static class TypeResolver
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IUserData, UserData>();
            services.AddTransient<IUserManager, UserManager>();
            return services;
        }
    }
}
