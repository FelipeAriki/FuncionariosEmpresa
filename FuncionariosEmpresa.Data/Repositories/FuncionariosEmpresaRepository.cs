using Dapper;
using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Data.Repositories
{
    public class FuncionariosEmpresaRepository : IFuncionariosEmpresaRepository
    {
        private readonly IDbConnection _connection;

        public FuncionariosEmpresaRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public async Task CreateAsync(FuncionarioEmpresa funcionario)
        {
            var sql = @" INSERT INTO ""Funcionario"" (""Nome"", ""Idade"", ""NomeDosPais"") VALUES (@Nome, @Idade, @NomeDosPais)";
            await _connection.ExecuteScalarAsync(sql, funcionario);
        }

        public async Task DeleteAsync(int id)
        {
            var sql = @" DELETE FROM ""Funcionario"" WHERE ""Id"" = @Id";
            await _connection.ExecuteScalarAsync(sql, new { Id = id });
        }

        public async Task<IEnumerable<FuncionarioEmpresa>> GetAllAsync()
        {
            var sql = @" SELECT * FROM ""Funcionario"" ";
            var resultado = await _connection.QueryAsync<FuncionarioEmpresa>(sql);
            return resultado.ToList();
        }

        public async Task<FuncionarioEmpresa> GetByIdAsync(int id)
        {
            var sql = @" SELECT * FROM ""Funcionario"" WHERE ""Id"" = @Id";
            var resultado = await _connection.QueryAsync<FuncionarioEmpresa>(sql, new { Id = id });
            return resultado.FirstOrDefault();
        }

        public async Task UpdateAsync(FuncionarioEmpresa funcionario)
        {
            var sql = @" UPDATE ""Funcionario""
                         SET ""Nome"" = @Nome, ""Idade"" = @Idade, ""NomeDosPais"" = @NomeDosPais
                         WHERE ""Id"" = @Id";
            await _connection.ExecuteScalarAsync(sql, funcionario);
        }
    }
}
