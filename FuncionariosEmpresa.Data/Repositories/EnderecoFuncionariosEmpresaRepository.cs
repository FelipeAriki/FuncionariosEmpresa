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
    public class EnderecoFuncionariosEmpresaRepository : IEnderecoFuncionariosEmpresaRepository
    {
        private readonly IFuncionariosEmpresaRepository _funcionariosEmpresaRepository;
        private readonly IDbConnection _connection;
        public EnderecoFuncionariosEmpresaRepository(IFuncionariosEmpresaRepository funcionariosEmpresaRepository, IDbConnection dbConnection)
        {
            _funcionariosEmpresaRepository = funcionariosEmpresaRepository;
            _connection = dbConnection;
        }
        public async Task CreateAsync(EnderecoFuncionariosEmpresa endereco)
        {
            var funcionario = await _funcionariosEmpresaRepository.GetByIdAsync(endereco.IdFuncionario);
            if (funcionario != null)
            {
                var sql = @"INSERT INTO ""Endereco""(""IdFuncionario"", ""Rua"", ""Numero"", ""Cep"", ""Cidade"", ""Estado"") VALUES (@IdFuncionario, @Rua, @Numero, @Cep, @Cidade, @Estado)";
                await _connection.ExecuteScalarAsync(sql, endereco);
            }
            
        }

        public async Task DeleteAsync(int id)
        {
            var sql = @"DELETE FROM ""Endereco"" WHERE ""Id"" = @Id";
            await _connection.ExecuteScalarAsync(sql, new { Id = id });
        }

        public async Task<IEnumerable<EnderecoFuncionariosEmpresa>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Endereco""";
            var resultado = await _connection.QueryAsync<EnderecoFuncionariosEmpresa>(sql);
            return resultado.ToList();
        }

        public async Task<EnderecoFuncionariosEmpresa> GetByIdAsync(int id)
        {
            var sql = @"SELECT * FROM ""Endereco"" WHERE ""Id"" = @Id";
            var resultado = await _connection.QueryAsync<EnderecoFuncionariosEmpresa>(sql, new { Id = id });
            return resultado.FirstOrDefault();
        }

        public async Task UpdateAsync(EnderecoFuncionariosEmpresa endereco)
        {
            var funcionario = await _funcionariosEmpresaRepository.GetByIdAsync(endereco.IdFuncionario);
            if(funcionario != null)
            {
                var sql = @"UPDATE ""Endereco""
                           SET ""IdFuncionario"" = @IdFuncionario, ""Rua"" = @Rua, ""Numero"" = @Numero, ""Cep"" = @Cep, ""Cidade"" = @Cidade, ""Estado"" = @Estado
                           WHERE ""Id"" = @Id";
                await _connection.ExecuteScalarAsync(sql, endereco);
            }
        }
    }
}
