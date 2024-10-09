using AIC_NetCore.Domain;
using AIC_NetCore.Persistance.DataAccessObjects_DAOs_;
using AIC_NetCore.Persistance.IRepositories;
using Dapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AIC_NetCore.Persistance
{
    public class Dapper_StudentRepository : IEntityRepository<Student>
    {
        private DataAccesObjectBase _dataAccesObject;
        public Dapper_StudentRepository(NpgsqlConnectionStringBuilder connectionBuilder)
        {
            _dataAccesObject = new pgsql_DataAccessObject(connectionBuilder.ConnectionString);
        }
        public Dapper_StudentRepository(string connectionString)
        {
            _dataAccesObject = new pgsql_DataAccessObject(connectionString);
        }

        public void AddStudent(Student student)
        {
            string Query = "INSERT INTO \"Students\" (\"Name\", \"Group\", \"Speciality\") VALUES (@Name, @Group, @Speciality)"; 

            _dataAccesObject.ExecuteWithOutReturn(Query, student);
        }

        public IEnumerable<Student> GetAllStudents()
        {

            return _dataAccesObject.ExecuteWithReturn<Student>("SELECT * FROM \"Students\"");
        }

        public bool IsStudentExist(Student student)
        {
            var result = _dataAccesObject.ExecuteWithReturn<Student>("SELECT 1 FROM \"Students\" " +
                    "WHERE \"Name\" = @Name AND \"Group\" = @Group AND \"Speciality\" = @Speciality"
                    ,new {student.Name, student.Group, student.Speciality});
            if(result.Count() > 0)
            {
                return true;
            }
            else { return false; }

        }

        public void RemoveStudent(Student student)
        {
            string query = "DELETE FROM \"Students\" WHERE \"Id\" = @Id";
            
            _dataAccesObject.ExecuteWithOutReturn(query, student);
        }

        public void UpdateStudent(Student studentToUpdate, Student Student)
        {
            _dataAccesObject.ExecuteWithOutReturn("UPDATE \"Students\" SET \"Name\" = @Name," +
                " \"Group\" = @Group, \"Speciality\" = @Speciality " +
                "WHERE \"Id\" = @Id"
                , new { Student.Name, Student.Group, Student.Speciality, studentToUpdate.Id});
        }
    }
}
