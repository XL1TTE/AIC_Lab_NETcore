using AIC_NetCore.Application.Dtos;
using AIC_NetCore.Application.IStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.ConsoleClient
{
    public class StudentConsoleHandler
    {
        private IStudentService _studentStore;
        public StudentConsoleHandler(IStudentService studentStore)
        {
            _studentStore = studentStore;
        }

        private void OutputAllStudentsToConsole()
        {

            string output = "";
            int counter = 0;
            var students = _studentStore.GetAllStudents();

            foreach (var student in students)
            {
                counter++;
                output += $"{counter}. {student.Name} | {student.Group} | {student.Speciality} \n";
            }

            Console.WriteLine(output);

        }

        private StudentDto ConsoleBuildStudent()
        {
            Console.WriteLine("Введите имя: ");

            var name = Console.ReadLine();

            Console.WriteLine("Введите группу: ");

            var group = Console.ReadLine();

            Console.WriteLine("Введите специализацию: ");

            var speciality = Console.ReadLine();

            return new StudentDto(name, group, speciality);
        }

        /// <summary>
        /// Updates console and shows list of commands.
        /// </summary>
        public void UpdateConsole()
        {
            Console.Clear();
            OutputAllStudentsToConsole();
            Console.WriteLine("\n Комманды: \n1. Добавить студента. \n2. Удалить студента. \n3. Обновить студента. \n4. Студенты по специальностям. \n5. Выйти.");

        }
        /// <summary>
        /// Adds student to DataBase with Console.
        /// </summary>
        public void AddStudent()
        {
            var student = ConsoleBuildStudent();
            _studentStore.AddStudent(student);
            UpdateConsole();

        }
        /// <summary>
        /// Removes student from DataBase with Console.
        /// </summary>
        public void RemoveStudent()
        {
            Console.WriteLine("Какого студента удалить (Введите номер)");
            var index = Int32.Parse(Console.ReadLine()) - 1;

            var student = _studentStore.GetAllStudents()[index];
            _studentStore.RemoveStudent(student);
            UpdateConsole();
        }
        /// <summary>
        /// Update Student in DataBase with Console.
        /// </summary>
        public void UpdateStudent()
        {
            Console.WriteLine("Какого студента обновить (Введите номер)");
            var index = Int32.Parse(Console.ReadLine()) - 1;
            var student = ConsoleBuildStudent();
            var studentToUpdate = _studentStore.GetAllStudents()[index];

            _studentStore.UpdateStudent(studentToUpdate, student);
            UpdateConsole();
        }

        public void GetStudentSpecialitiesData()
        {
            string result = "....Распределение... \n\n";

            (List<string>, List<int>) data = _studentStore.GetStudentSpecialitiesData();
            var SpecNames = data.Item1;
            var StudentCounts = data.Item2;

            for (int i = 0; i < SpecNames.Count(); i++)
            {
                result += $"{SpecNames[i]} - {StudentCounts[i]} \n";
            }
            UpdateConsole();
            Console.WriteLine(result);

        }
    }
}
