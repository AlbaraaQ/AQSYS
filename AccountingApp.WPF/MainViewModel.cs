using System.Windows.Input;

namespace AccountingApp.WPF
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToUnitsCommand = new RelayCommand(_ => _navigationService.NavigateTo<UnitsView>());
            NavigateToCustomersCommand = new RelayCommand(_ => _navigationService.NavigateTo<CustomersView>());
            NavigateToEmployeesCommand = new RelayCommand(_ => _navigationService.NavigateTo<EmployeesView>());
        }

        public ICommand NavigateToUnitsCommand { get; }
        public ICommand NavigateToCustomersCommand { get; }
        public ICommand NavigateToEmployeesCommand { get; }
    }
}
