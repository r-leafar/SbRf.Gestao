using DesktopApp.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SbRf.Gestao.Infra.Sqlite;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ServiceProvider Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();

            IConfigurationRoot config = BuildApplicationConfiguration();

            services.AddSingleton<IConfiguration>(config);

            // Registrando Infra
            services.AddInfraSqlite(config);

            // Registrando UI
            services.AddSingleton<MainWindow>();
            services.AddScoped<ProdutoWindow>();
            services.AddTransient<ProdutoViewModel>();

            Services = services.BuildServiceProvider();

            //var mainWindow = Services.GetRequiredService<MainWindow>();
            //mainWindow.Show();
        }

        private IConfigurationRoot BuildApplicationConfiguration()
        {
            var config = new ConfigurationBuilder()
                     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)

#if DEBUG
                     .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
#else
                     .AddJsonFile("appsettings.Production.json", optional: true, reloadOnChange: true)
#endif
                     .AddEnvironmentVariables().Build();
            return config;
        }
    }

    

}
