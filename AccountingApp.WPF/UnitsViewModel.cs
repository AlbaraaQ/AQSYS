using AccountingApp.Core;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountingApp.WPF
{
    public class UnitsViewModel : ViewModelBase
    {
        private readonly IUnitsRepository _unitsRepository;
        private readonly IReportService _reportService;
        private readonly INavigationService _navigationService;
        private ObservableCollection<Unit> _units;
        private Unit _selectedUnit;

        public UnitsViewModel(IUnitsRepository unitsRepository, IReportService reportService, INavigationService navigationService)
        {
            _unitsRepository = unitsRepository;
            _reportService = reportService;
            _navigationService = navigationService;
            LoadUnits();
            NewCommand = new RelayCommand(New);
            SaveCommand = new RelayCommand(Save, CanSave);
            DeleteCommand = new RelayCommand(Delete, CanDelete);
            PrintCommand = new RelayCommand(Print);
        }

        public ObservableCollection<Unit> Units
        {
            get => _units;
            set
            {
                _units = value;
                OnPropertyChanged();
            }
        }

        public Unit SelectedUnit
        {
            get => _selectedUnit;
            set
            {
                _selectedUnit = value;
                OnPropertyChanged();
            }
        }

        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand PrintCommand { get; }

        private void LoadUnits()
        {
            Units = new ObservableCollection<Unit>(_unitsRepository.GetAll());
        }

        private void New(object parameter)
        {
            SelectedUnit = new Unit();
        }

        private bool CanSave(object parameter)
        {
            return SelectedUnit != null && !string.IsNullOrWhiteSpace(SelectedUnit.Name);
        }

        private void Save(object parameter)
        {
            if (SelectedUnit.Id == 0)
            {
                _unitsRepository.Add(SelectedUnit);
            }
            else
            {
                _unitsRepository.Update(SelectedUnit);
            }
            LoadUnits();
        }

        private bool CanDelete(object parameter)
        {
            return SelectedUnit != null && SelectedUnit.Id != 0;
        }

        private void Delete(object parameter)
        {
            _unitsRepository.Delete(SelectedUnit.Id);
            LoadUnits();
        }

        private void Print(object parameter)
        {
            var report = _reportService.CreateUnitsReport();
            var reportViewModel = new ReportViewModel { Report = report };
            var reportView = new ReportView(reportViewModel);
            reportView.Show();
        }
    }
}
