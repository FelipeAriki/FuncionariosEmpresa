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

        public Task CreateAsync(FuncionarioEmpresa funcionario)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FuncionarioEmpresa>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioEmpresa> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(FuncionarioEmpresa funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
