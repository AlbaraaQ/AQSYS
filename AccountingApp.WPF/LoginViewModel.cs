using AccountingApp.Core;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace AccountingApp.WPF
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly INavigationService _navigationService;
        private string _username;
        private string _errorMessage;

        public LoginViewModel(IAuthenticationService authenticationService, INavigationService navigationService)
        {
            _authenticationService = authenticationService;
            _navigationService = navigationService;
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

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

        public ICommand LoginCommand { get; }

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username) && parameter is PasswordBox;
        }

        private void Login(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            if (passwordBox == null)
            {
                return;
            }

            var user = _authenticationService.Authenticate(Username, passwordBox.Password);
            if (user != null)
            {
                _navigationService.NavigateTo<MainWindow>();
                (passwordBox.Parent as Window)?.Close();
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
