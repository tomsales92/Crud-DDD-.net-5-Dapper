using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.Domain
{
    public interface IUnitOfWork
    {
        void StartTransaction();
        void ExecuteCommit();
        void ExecuteRollback();
    }
}
