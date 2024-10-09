using AIC_NetCore.Domain;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.Persistance.DataAccessObjects_DAOs_
{
    public class pgsql_DataAccessObject : DataAccesObjectBase
    { 
        public pgsql_DataAccessObject(string connectionString) : base(connectionString) { }
        public override IEnumerable<DomainEntity> ExecuteWithReturn<DomainEntity>(string SqlQuery, object? parameters = null)
        {
            IEnumerable<DomainEntity> result;
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                result = conn.Query<DomainEntity>(SqlQuery, parameters);

                conn.Close();
            }

            return result;
        }

        public override void ExecuteWithOutReturn(string SqlQuery, object? parameters = null)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                conn.Execute(SqlQuery, parameters);

                conn.Close();
            }
        }
    }
}
