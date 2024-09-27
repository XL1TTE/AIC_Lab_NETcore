using AIC_NetCore.Domain;
using AIC_NetCore.Persistance.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.Persistance
{
    public class EF_StudentRepository : IEntityRepository<Student>
    {
        private List<Student> _students = new List<Student>()
        {
                new Student("Студент1", "IT_1", "Group1"),
                new Student("Студент2", "IT_2", "Group2"),
                new Student("Студент3", "IT_3", "Group3"),
                new Student("Студент4", "IT_4", "Group4"),
                new Student("Студент8", "IT_4", "Group4"),
                new Student("Студент9", "IT_4", "Group4"),
                new Student("Студент5", "IT_5", "Group5"),
                new Student("Студент6", "IT_5", "Group5"),
                new Student("Студент7", "IT_5", "Group5"),
        };

        public bool IsStudentExist(Student student)
        {
            return _students.Contains(student);
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {

            return _students;
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

        public void UpdateStudent(Student studentToUpdate, Student student)
        {
            var student_index = _students.FindIndex(s =>
            s.Name == studentToUpdate.Name &&
            s.Speciality == studentToUpdate.Speciality &&
            s.Group == studentToUpdate.Group);

            _students[student_index] = student;


        }
    }
}
