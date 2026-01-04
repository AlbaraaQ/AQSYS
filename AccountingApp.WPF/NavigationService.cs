using AccountingApp.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace AccountingApp.WPF
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void NavigateTo<T>() where T : Window
        {
            var window = _serviceProvider.GetRequiredService<T>();
            window.Show();
        }
    }
}
