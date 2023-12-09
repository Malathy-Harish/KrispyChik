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

        /// <summary>
        /// It will get data from business Manager. Then, we get data from DB as the List
        /// </summary>
        /// <returns>It will return the list of user</User></returns>
        public List<User> GetAllUsers()
        {
            return _userdb.Users.ToList();

        }

        
    }
}
