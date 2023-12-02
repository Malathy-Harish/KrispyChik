using KrispyChik.Entities;
using KrispyChik.Model;

namespace KrispyChik.Business_Contracts
{
    public interface IUserManager
    {
        List<User> GetAllUsers();
    }
}
