using KrispyChik.Business_Contracts;
using KrispyChik.Data_Contracts;
using KrispyChik.Entities;
using KrispyChik.Model;

namespace KrispyChik.Business_Manager
{
    public class UserManager : IUserManager
    {
        private readonly IUserData _userdata;
        public UserManager(IUserData userdata) 
        { 
            _userdata = userdata;
        }

        public List<User> GetAllUsers()
        {
            return _userdata.GetAllUsers();
        }

       
    }
}
