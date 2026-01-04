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
            services.AddTransient<LoginViewModel>();
            services.AddTransient<LoginView>();
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
