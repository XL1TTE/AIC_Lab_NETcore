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
        IEnumerable<Entity> GetAllStudents();
        bool IsStudentExist(Entity student);
        void AddStudent(Entity student);
        void UpdateStudent(Entity studentToUpdate, Entity Student);
        void RemoveStudent(Entity student);
    }
}
