using rm_api.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.infra.repositories.Base
{
    public class ConnectionManager : IConnectionManager, IUnitOfWork, IDisposable
    {

        private readonly IDbConnection _connection;

        public IDbTransaction ActiveTransaction { get; private set; }

        public ConnectionManager(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void StartTransaction()
        {
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
           ActiveTransaction = _connection.BeginTransaction();
        }

       

        public IDbConnection GetConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }


        public void ExecuteCommit()
        {
            if (ActiveTransaction == null)
            {
                throw new InvalidOperationException("The transaction must be open.");
            }
            ActiveTransaction.Commit();
            ActiveTransaction = null;
        }

        public void Dispose()
        {
            ActiveTransaction?.Dispose();
            _connection.Close();
        }
    




        public void ExecuteRollback()
        {
            if (ActiveTransaction == null)
            {
                throw new InvalidOperationException("The transaction must be opened.");
            }
            ActiveTransaction.Rollback();
            ActiveTransaction = null;
        }



    }
}
