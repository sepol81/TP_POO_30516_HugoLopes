using EMS.Data;
using EMS.Interfaces;
using EMS.Services;
using EMS.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Serilog;

namespace EMS_AP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(@"C:\Users\Lenovo\Desktop\TP_POO_30516_HugoLopes\EMS\Logs\log.txt",
                    rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection()
            .AddTransient<LoginForm>();

            DepInjection.ConfigServ(services);
                        
            var serviceProvider = services.BuildServiceProvider();
                       
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();

            var logger = serviceProvider.GetRequiredService<ILoggerFactory>().CreateLogger("ApplicationLogger");
            logger.LogInformation("Aplicação iniciada com sucesso.");
                                 

            Application.Run(loginForm);

            Log.CloseAndFlush();

        }
    }
}
