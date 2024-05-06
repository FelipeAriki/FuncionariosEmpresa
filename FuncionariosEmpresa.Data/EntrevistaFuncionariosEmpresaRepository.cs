using Dapper;
using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Data
{
    public class EntrevistaFuncionariosEmpresaRepository : IEntrevistaFuncionariosEmpresaRepository
    {
        private readonly IDbConnection _connection;

        public EntrevistaFuncionariosEmpresaRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public async Task CreateAsync(EntrevistaFuncionariosEmpresa entrevista)
        {
            var sql = @"INSERT INTO ";

            await _connection.ExecuteAsync(sql, entrevista);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EntrevistaFuncionariosEmpresa>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EntrevistaFuncionariosEmpresa> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EntrevistaFuncionariosEmpresa entrevistas)
        {
            throw new NotImplementedException();
        }
    }
}
