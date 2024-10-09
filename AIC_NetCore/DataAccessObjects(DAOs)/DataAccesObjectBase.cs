using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_NetCore.Persistance.DataAccessObjects_DAOs_
{
    public abstract class DataAccesObjectBase
    {
        protected readonly string _connectionString;
        protected DataAccesObjectBase(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        public virtual IEnumerable<DomainEntity> ExecuteWithReturn<DomainEntity>(string SqlQuery, object? parameters = null)
        {
            throw new NotImplementedException();
        }

        public virtual void ExecuteWithOutReturn(string SqlQuery, object? parameters = null)
        {
            throw new NotImplementedException();
        }
    }
}
