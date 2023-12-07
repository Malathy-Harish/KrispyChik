namespace KrispyChik.Business_Contracts
{
    public interface IAuthManager
    {
        bool CheckPassword(string UserName, string Password);
    }
}
