using Dapper;
using rm_api.Domain.Solicitations;
using rm_api.Domain.Solicitations.Interfaces;
using rm_api.infra.repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.infra.repositories.Solicitations
{
    public class SolicitationsRepository : ISolicitationsRepository
    {
        private readonly IConnectionManager _connectionManager;

        public SolicitationsRepository(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public Solicitation Get(int id)
        {
            var connection = _connectionManager.GetConnection();
            string sql = $"select * from solicitations where id = {id}";
            return connection.QueryFirstOrDefault<Solicitation>(sql);
            
        }

        public IEnumerable<Solicitation> GetAll()
        {
            var connection = _connectionManager.GetConnection();
            string sql = "select * from solicitations";
            var solicitations =  connection.Query<Solicitation>(sql);
            return solicitations;
           
        }

        public void Create(Solicitation solicitation)
        {
            var connection = _connectionManager.GetConnection();
            string sql = $"insert into solicitations (name) values ('{solicitation.Name}')";
            connection.Execute(sql);

        }

        public void Update(Solicitation solicitation)
        {
            var connection = _connectionManager.GetConnection();
            string sql = $"update solicitations set  name = '{solicitation.Name}' where id = {solicitation.Id};";
            connection.Execute(sql);

        }

        public void Delete(int id)
        {
            var connection = _connectionManager.GetConnection();
            string sql = $"delete from solicitations where id = {id}";
            connection.Execute(sql);
        }
    }
}
