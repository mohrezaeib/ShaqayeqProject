using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;

        public App()
        {
            host = new HostBuilder()
           .ConfigureServices((hostContext, services) =>
           {
               services.AddScoped<IMainWindowModel, MainWindowModel>();

              services.AddDbContext<SchoolContext>(opt => opt.UseSqlServer("Server=localhost;Database=WpfApp1;Trusted_Connection=True;"));
               services.AddSingleton<MainWindow>();
           }).Build();

            using (var serviceScope = host.Services.CreateScope()  )
            {
                var service = serviceScope.ServiceProvider;
              
                try
                {
                    var masterWindow = service.GetRequiredService<MainWindow>();
                    masterWindow.Show();
                    Console.WriteLine("success");
                }catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }


        }
    }
}
