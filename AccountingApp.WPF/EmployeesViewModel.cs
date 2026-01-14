using AccountingApp.Core;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace AccountingApp.WPF
{
    public class EmployeesViewModel : ViewModelBase
    {
        private readonly IEmployeesRepository _employeesRepository;
        private readonly ILookupRepository<Management> _managementRepository;
        private readonly ILookupRepository<Department> _departmentRepository;
        private readonly ILookupRepository<Job> _jobRepository;
        private readonly ILookupRepository<MaritalStatus> _maritalStatusRepository;
        private readonly ILookupRepository<State> _stateRepository;
        private readonly INationalityRepository _nationalityRepository;
        private readonly IBranchesRepository _branchesRepository;

        private ObservableCollection<Employee> _employees;
        private Employee _selectedEmployee;
        private ObservableCollection<Branch> _employeeBranches;

        public EmployeesViewModel(
            IEmployeesRepository employeesRepository,
            ILookupRepository<Management> managementRepository,
            ILookupRepository<Department> departmentRepository,
            ILookupRepository<Job> jobRepository,
            ILookupRepository<MaritalStatus> maritalStatusRepository,
            ILookupRepository<State> stateRepository,
            INationalityRepository nationalityRepository,
            IBranchesRepository branchesRepository)
        {
            _employeesRepository = employeesRepository;
            _managementRepository = managementRepository;
            _departmentRepository = departmentRepository;
            _jobRepository = jobRepository;
            _maritalStatusRepository = maritalStatusRepository;
            _stateRepository = stateRepository;
            _nationalityRepository = nationalityRepository;
            _branchesRepository = branchesRepository;

            LoadEmployees();
            LoadLookups();

            NewCommand = new RelayCommand(New);
            SaveCommand = new RelayCommand(Save, CanSave);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
        }

        public ObservableCollection<Employee> Employees { get => _employees; set { _employees = value; OnPropertyChanged(); } }
        public Employee SelectedEmployee { get => _selectedEmployee; set { _selectedEmployee = value; OnPropertyChanged(); LoadEmployeeBranches(); } }
        public ObservableCollection<Branch> EmployeeBranches { get => _employeeBranches; set { _employeeBranches = value; OnPropertyChanged(); } }

        public ObservableCollection<Management> Managements { get; set; }
        public ObservableCollection<Department> Departments { get; set; }
        public ObservableCollection<Job> Jobs { get; set; }
        public ObservableCollection<MaritalStatus> MaritalStatuses { get; set; }
        public ObservableCollection<State> States { get; set; }
        public ObservableCollection<Nationality> Nationalities { get; set; }
        public ObservableCollection<Branch> AllBranches { get; set; }

        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }

        private void LoadEmployees()
        {
            Employees = new ObservableCollection<Employee>(_employeesRepository.GetAll());
        }

        private void LoadLookups()
        {
            Managements = new ObservableCollection<Management>(_managementRepository.GetAll());
            Departments = new ObservableCollection<Department>(_departmentRepository.GetAll());
            Jobs = new ObservableCollection<Job>(_jobRepository.GetAll());
            MaritalStatuses = new ObservableCollection<MaritalStatus>(_maritalStatusRepository.GetAll());
            States = new ObservableCollection<State>(_stateRepository.GetAll());
            Nationalities = new ObservableCollection<Nationality>(_nationalityRepository.GetAll());
            AllBranches = new ObservableCollection<Branch>(_branchesRepository.GetAll());
        }

        private void LoadEmployeeBranches()
        {
            if (SelectedEmployee != null)
            {
                EmployeeBranches = new ObservableCollection<Branch>(_employeesRepository.GetEmployeeBranches(SelectedEmployee.Id));
            }
        }

        private void New(object parameter)
        {
            SelectedEmployee = new Employee();
            EmployeeBranches = new ObservableCollection<Branch>();
        }

        private bool CanSave(object parameter)
        {
            return SelectedEmployee != null && !string.IsNullOrWhiteSpace(SelectedEmployee.Name);
        }

        private void Save(object parameter)
        {
            var branchIds = EmployeeBranches.Select(b => b.Id);
            if (SelectedEmployee.Id == 0)
            {
                _employeesRepository.Add(SelectedEmployee, branchIds);
            }
            else
            {
                _employeesRepository.Update(SelectedEmployee, branchIds);
            }
            LoadEmployees();
        }

        private bool CanDelete(object parameter)
        {
            return SelectedEmployee != null && SelectedEmployee.Id != 0;
        }

        private void Delete(object parameter)
        {
            _employeesRepository.Delete(SelectedEmployee.Id);
            LoadEmployees();
        }
    }
}
