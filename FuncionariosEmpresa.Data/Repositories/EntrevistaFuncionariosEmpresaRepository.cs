using Dapper;
using Dapper.Contrib.Extensions;
using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Data.Repositories
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
            var sql = @"INSERT INTO ""Entrevista"" (""Empresa"", ""DataEntrevista"", ""Salario"", ""ResponsavelVaga"") VALUES (@Empresa, @DataEntrevista, @Salario, @ResponsavelVaga)";

            await _connection.ExecuteScalarAsync(sql, entrevista);
        }

        public async Task DeleteAsync(int id)
        {
            var sql = @"DELETE FROM ""Entrevista"" WHERE ""Id"" = @id";

            await _connection.ExecuteScalarAsync(sql, new { id });
        }

        public async Task<IEnumerable<EntrevistaFuncionariosEmpresa>> GetAllAsync()
        {
            var sql = @" SELECT * FROM ""Entrevista"" ";
            var resultado = await _connection.QueryAsync<EntrevistaFuncionariosEmpresa>(sql);
            return resultado.ToList();
        }

        public async Task<EntrevistaFuncionariosEmpresa> GetAsync(int id)
        {
            var sql = @" SELECT * FROM ""Entrevista"" WHERE ""Id"" = @Id";
            var resultado = await _connection.QueryAsync<EntrevistaFuncionariosEmpresa>(sql, new { Id = id });
            return resultado.FirstOrDefault();
        }

        public async Task UpdateAsync(EntrevistaFuncionariosEmpresa entrevistas)
        {
            var sql = @"UPDATE ""Entrevista""
                       SET ""Empresa"" = @Empresa, ""DataEntrevista"" = @DataEntrevista, ""Salario"" = @Salario, ""ResponsavelVaga"" = @ResponsavelVaga
                       WHERE ""Id"" = @Id";

            await _connection.ExecuteScalarAsync(sql, entrevistas);
        }
    }
}
