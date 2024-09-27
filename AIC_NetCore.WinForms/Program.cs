using AIC_NetCore.Application.IStores;
using AIC_NetCore.Application;
using AIC_NetCore.WinForms.Controls;
using AIC_NetCore.WinForms.Services;
using Microsoft.Extensions.DependencyInjection;
using AIC_NetCore.Persistance.IRepositories;
using AIC_NetCore.Domain;
using AIC_NetCore.Persistance;

namespace AIC_NetCore.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IEntityRepository<Student>, EF_StudentRepository>()
                .AddSingleton<IStudentService, StudentService>()
                .AddSingleton<MainForm>()
                .AddSingleton<StudentTableView>()
                .AddSingleton<StudentGraphicView>()
                .AddSingleton<Func<Type, UserControl>>(p => type => (UserControl)p.GetRequiredService(type))
                .AddSingleton<INavigationService, NavigationService>()
                .BuildServiceProvider();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }
    }
}