using AIC_NetCore.Domain;
using AIC_NetCore.Persistance.DbContexts;
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
        private readonly DecanatDbContext _db;
        public EF_StudentRepository()
        {
            _db = new DecanatDbContext();
        }

        public bool IsStudentExist(Student student)
        {
            return _db.Students.Any(x => x.Name == student.Name
                               && x.Group == student.Group
                               && x.Speciality == student.Speciality
                               && x.Id != student.Id);
        }
        public void AddStudent(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {

            return _db.Students.OrderBy(x => x.Id).ToList();
        }

        public void RemoveStudent(Student student)
        {
            var ToDelete = _db.Students.FirstOrDefault(x => x == student);

            _db.Students.Remove(ToDelete);
            _db.SaveChanges();
        }

        public void UpdateStudent(Student studentToUpdate, Student student)
        {
            var StudentToUpdate = _db.Students.Find(studentToUpdate.Id);

            StudentToUpdate.Name = student.Name;
            StudentToUpdate.Group = student.Group;
            StudentToUpdate.Speciality = student.Speciality;  

            _db.SaveChanges();
        }
    }
}
