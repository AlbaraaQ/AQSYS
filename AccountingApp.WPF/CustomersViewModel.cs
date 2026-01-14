using AccountingApp.Core;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountingApp.WPF
{
    public class CustomersViewModel : ViewModelBase
    {
        private readonly ICustomersRepository _customersRepository;
        private ObservableCollection<Customer> _customers;
        private Customer _selectedCustomer;
        private int _customerType = 1;

        public CustomersViewModel(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
            LoadCustomers();
            NewCommand = new RelayCommand(New);
            SaveCommand = new RelayCommand(Save, CanSave);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
        }

        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                OnPropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        public int CustomerType
        {
            get => _customerType;
            set
            {
                _customerType = value;
                LoadCustomers();
                OnPropertyChanged();
            }
        }

        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }

        private void LoadCustomers()
        {
            Customers = new ObservableCollection<Customer>(_customersRepository.GetByType(CustomerType));
        }

        private void New(object parameter)
        {
            SelectedCustomer = new Customer { Type = CustomerType };
        }

        private bool CanSave(object parameter)
        {
            return SelectedCustomer != null && !string.IsNullOrWhiteSpace(SelectedCustomer.Name);
        }

        private void Save(object parameter)
        {
            if (SelectedCustomer.Id == 0)
            {
                _customersRepository.Add(SelectedCustomer);
            }
            else
            {
                _customersRepository.Update(SelectedCustomer);
            }
            LoadCustomers();
        }

        private bool CanDelete(object parameter)
        {
            return SelectedCustomer != null && SelectedCustomer.Id != 0;
        }

        private void Delete(object parameter)
        {
            _customersRepository.Delete(SelectedCustomer.Id);
            LoadCustomers();
        }
    }
}
