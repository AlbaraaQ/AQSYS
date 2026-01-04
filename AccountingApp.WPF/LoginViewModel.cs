using AccountingApp.Core;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace AccountingApp.WPF
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly INavigationService _navigationService;
        private readonly IBranchesRepository _branchesRepository;
        private string _username;
        private string _errorMessage;
        private Branch _selectedBranch;

        public event Action RequestClose;

        public LoginViewModel(IAuthenticationService authenticationService, INavigationService navigationService, IBranchesRepository branchesRepository)
        {
            _authenticationService = authenticationService;
            _navigationService = navigationService;
            _branchesRepository = branchesRepository;
            LoadBranches();
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        public ObservableCollection<Branch> Branches { get; set; }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public Branch SelectedBranch
        {
            get => _selectedBranch;
            set
            {
                _selectedBranch = value;
                OnPropertyChanged(nameof(SelectedBranch));
            }
        }

        public ICommand LoginCommand { get; }

        private void LoadBranches()
        {
            Branches = new ObservableCollection<Branch>(_branchesRepository.GetAll());
        }

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username) && parameter is PasswordBox && SelectedBranch != null;
        }

        private void Login(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            if (passwordBox == null)
            {
                return;
            }

            var user = _authenticationService.Authenticate(Username, passwordBox.Password, SelectedBranch.Id);
            if (user != null)
            {
                _navigationService.NavigateTo<MainWindow>();
                RequestClose?.Invoke();
            }
            else
            {
                ErrorMessage = "Invalid username or password for the selected branch.";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
