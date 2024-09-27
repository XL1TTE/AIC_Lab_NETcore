using AIC_NetCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.Application.Dtos.Mappers
{
    public class DtoMappers
    {
        #region Student Mappers

        public static Student StudentMapper(StudentDto studentDto)
        {
            return new Student
            {
                Name = studentDto.Name,
                Group = studentDto.Group,
                Speciality = studentDto.Speciality,
            };
        }
        public static StudentDto StudentMapper(Student student)
        {
            return new StudentDto
            {
                Name = student.Name,
                Group = student.Group,
                Speciality = student.Speciality,
            };
        }
        public static List<StudentDto> StudentMapper(IEnumerable<Student> students)
        {
            List<StudentDto> result = new List<StudentDto>();
            foreach (var student in students)
            {
                var Student = StudentMapper(student);
                result.Add(Student);
            }
            return result;
        }
        public static List<Student> StudentMapper(IEnumerable<StudentDto> students)
        {
            List<Student> result = new List<Student>();
            foreach (var student in students)
            {
                var Student = StudentMapper(student);
                result.Add(Student);
            }
            return result;
        }

        #endregion
    }
}
