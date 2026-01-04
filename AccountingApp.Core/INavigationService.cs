namespace AccountingApp.Core
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : System.Windows.Window;
    }
}
