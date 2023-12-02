using KrispyChik.Data_Contracts;
using KrispyChik.Entities;
using KrispyChik.Model;

namespace KrispyChik.Data_Access
{
    public class UserData : IUserData
    {
        private readonly AppDataContext _userdb;
        public UserData(AppDataContext userdb)
        {
            _userdb = userdb;
        }

        public List<User> GetAllUsers()
        {
            return _userdb.Users.ToList();

        }

        
    }
}
