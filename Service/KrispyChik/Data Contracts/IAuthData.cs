using KrispyChik.Entities;

namespace KrispyChik.Data_Contracts
{
    public interface IAuthData
    {
        bool Checkpassword(string UserName, string Password);
    }
}
