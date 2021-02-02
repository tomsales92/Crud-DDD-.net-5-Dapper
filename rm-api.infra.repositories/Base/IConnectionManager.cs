using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.infra.repositories.Base
{
    public interface IConnectionManager
    {
        IDbTransaction ActiveTransaction { get;  }
        IDbConnection GetConnection();
    }
}
