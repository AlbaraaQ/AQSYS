using AccountingApp.Core;
using AccountingApp.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace AccountingApp.WPF
{
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IAuthenticationService>(new AuthenticationService(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IUnitsRepository>(new UnitsRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<ICustomersRepository>(new CustomersRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IEmployeesRepository>(new EmployeesRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IBranchesRepository>(new BranchesRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<ILookupRepository<Management>>(new LookupRepository<Management>(configuration.GetConnectionString("DefaultConnection"), "Managements"));
            services.AddSingleton<ILookupRepository<Department>>(new LookupRepository<Department>(configuration.GetConnectionString("DefaultConnection"), "Departments"));
            services.AddSingleton<ILookupRepository<Job>>(new LookupRepository<Job>(configuration.GetConnectionString("DefaultConnection"), "Jobs"));
            services.AddSingleton<ILookupRepository<MaritalStatus>>(new LookupRepository<MaritalStatus>(configuration.GetConnectionString("DefaultConnection"), "Marital_status"));
            services.AddSingleton<ILookupRepository<State>>(new LookupRepository<State>(configuration.GetConnectionString("DefaultConnection"), "States"));
            services.AddSingleton<INationalityRepository>(new NationalityRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IFoundationRepository>(new FoundationRepository(configuration.GetConnectionString("DefaultConnection")));
            services.AddSingleton<IReportService, ReportService>();

            services.AddTransient<LoginViewModel>();
            services.AddTransient<LoginView>();
            services.AddTransient<UnitsViewModel>();
            services.AddTransient<UnitsView>();
            services.AddTransient<CustomersViewModel>();
            services.AddTransient<CustomersView>();
            services.AddTransient<EmployeesViewModel>();
            services.AddTransient<EmployeesView>();
            services.AddTransient<ReportViewModel>();
            services.AddTransient<ReportView>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainWindow>();
            services.AddSingleton<INavigationService, NavigationService>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var loginView = _serviceProvider.GetRequiredService<LoginView>();
            loginView.Show();
        }
    }
}
