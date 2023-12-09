using KrispyChik.Data_Contracts;
using KrispyChik.Entities;

namespace KrispyChik.Data_Access
{
    public class AuthData: IAuthData
    {
        private readonly AppDataContext _context;
        public AuthData(AppDataContext context)
        {
            _context = context;
        }

        public Auth GetPasswordbyId(int UserId)
        {
            Auth res = new Auth();

            res = _context.Auths.Where(e => e.UserId == UserId).FirstOrDefault();
            return res;
        }

        public List<Auth> GetAllAuths()
        {
            return _context.Auths.ToList();
        }

        public bool Checkpassword(string UserName, string Password)
        {
            //var a = from User in _context.Users
            //        join Auth in _context.Auths on
            //        User.UserId equals Auth.UserId
            //        where
            //        User.Name == UserName && Auth.Password == Password
            //        select User;

            //var result = _context.Users.Join(_context.Auths, usr => usr.UserId,
            //                            auth =>auth.UserId,
            //                            (usr, auth) => new { usr,auth})
            //                            .Where(e => e.usr.Name == UserName && e.auth.Password==Password)
            //                            .Count() >0;

            //var user = _context.Users.FirstOrDefault(b => b.Name == UserName);
            //var checkpassword = _context.Auths.FirstOrDefault(b => b.Password == Password && b.UserId==user.UserId);
           

            

            return true; 

        }

       
    }
}
