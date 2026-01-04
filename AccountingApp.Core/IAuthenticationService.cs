namespace AccountingApp.Core
{
    public interface IAuthenticationService
    {
        User Authenticate(string username, string password, int branchId);
    }
}
