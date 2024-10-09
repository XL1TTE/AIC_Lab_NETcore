using Microsoft.Extensions.DependencyInjection;
using AIC_NetCore.Application;
using AIC_NetCore.Domain;
using AIC_NetCore.Persistance;
using AIC_NetCore.Application.IStores;
using AIC_NetCore.Persistance.IRepositories;

namespace AIC_NetCore.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _serviceProvider = new ServiceCollection()
            .AddSingleton<IStudentService, StudentService>()
            .AddSingleton<IEntityRepository<Student>, EF_StudentRepository>(p =>
            new EF_StudentRepository("Host=localhost;Port=5432;Username=postgres;Password=Dsbuhsdf.gentdre1;Database=aicDecanat"))
            .AddSingleton<StudentConsoleHandler>()
            .BuildServiceProvider();

            var StudentConsoleHandler = _serviceProvider.GetRequiredService<StudentConsoleHandler>();

            var Exit = false;


            StudentConsoleHandler.UpdateConsole();

            while (!Exit)
            {

                Console.WriteLine("Введите номер операции.");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        StudentConsoleHandler.AddStudent();
                        break;
                    case "2":
                        StudentConsoleHandler.RemoveStudent();
                        break;

                    case "3":
                        StudentConsoleHandler.UpdateStudent();
                        break;
                    case "4":
                        StudentConsoleHandler.GetStudentSpecialitiesData();
                        break;
                    case "5":
                        Exit = true;
                        break;
                }

            }
        }
    }
}
