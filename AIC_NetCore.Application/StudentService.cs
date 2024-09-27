using AIC_NetCore.Application.Dtos.Mappers;
using AIC_NetCore.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIC_NetCore.Persistance.IRepositories;
using AIC_NetCore.Domain;
using AIC_NetCore.Application.IStores;

namespace AIC_NetCore.Application
{
    public class StudentService : IStudentService
    {
        public IEntityRepository<Student> studentRepository { get; set; }
        public StudentService(IEntityRepository<Student> studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public bool IsStudentExist(StudentDto studentDto)
        {
            var student = DtoMappers.StudentMapper(studentDto);
            return studentRepository.IsStudentExist(student);
        }
        public void AddStudent(StudentDto studentDto)
        {
            var student = DtoMappers.StudentMapper(studentDto);
            studentRepository.AddStudent(student);
        }

        public void UpdateStudent(StudentDto studentToUpdate, StudentDto studentDto)
        {
            var StudentToUpdate = DtoMappers.StudentMapper(studentToUpdate);
            var Student = DtoMappers.StudentMapper(studentDto);
            studentRepository.UpdateStudent(StudentToUpdate, Student);
        }

        public List<StudentDto> GetAllStudents()
        {
            return DtoMappers.StudentMapper(studentRepository.GetAllStudents());
        }

        public void RemoveStudent(StudentDto student)
        {
            var Student = DtoMappers.StudentMapper(student);
            studentRepository.RemoveStudent(Student);
        }

        /// <summary>
        /// Return information about count of students in each speciality.
        /// </summary>
        /// <returns>(List of specialities, List of student applied to it.)</returns>
        public (List<string>, List<int>) GetStudentSpecialitiesData()
        {
            var SpecialitesValues = new List<int>();
            var SpicialitiesTitles = new List<string>();

            var specialtyCounts = studentRepository.GetAllStudents()
                .GroupBy(s => s.Speciality)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count()
                }).ToList();

            foreach (var specialty in specialtyCounts)
            {
                SpicialitiesTitles.Add(specialty.Title);
                SpecialitesValues.Add(specialty.Count);

            }
            return (SpicialitiesTitles, SpecialitesValues);
        }
    }
}
