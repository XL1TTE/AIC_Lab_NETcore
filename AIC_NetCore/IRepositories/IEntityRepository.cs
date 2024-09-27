using AIC_NetCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.Persistance.IRepositories
{
    public interface IEntityRepository<Entity> where Entity: IDomainEntity
    {
        IEnumerable<Student> GetAllStudents();
        bool IsStudentExist(Student student);
        void AddStudent(Student student);
        void UpdateStudent(Student studentToUpdate, Student Student);
        void RemoveStudent(Student student);
    }
}
