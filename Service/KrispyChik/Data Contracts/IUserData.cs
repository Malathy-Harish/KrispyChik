using KrispyChik.Entities;
using KrispyChik.Model;

namespace KrispyChik.Data_Contracts
{
    public interface IUserData
    {
        List<User> GetAllUsers();

    }
}
