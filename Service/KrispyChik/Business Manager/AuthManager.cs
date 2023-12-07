using KrispyChik.Business_Contracts;
using KrispyChik.Data_Contracts;

namespace KrispyChik.Business_Manager
{
    public class AuthManager: IAuthManager
    {
        private readonly IAuthData _authdata;
        public AuthManager(IAuthData authdata) 
        {
            _authdata = authdata;
        }

        public bool CheckPassword(string UserName, string Password)
        {
           return _authdata.Checkpassword(UserName, Password);
            
        }

    }
}
