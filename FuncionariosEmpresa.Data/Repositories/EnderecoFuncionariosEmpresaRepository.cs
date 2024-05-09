using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Data.Repositories
{
    public class EnderecoFuncionariosEmpresaRepository : IEnderecoFuncionariosEmpresaRepository
    {
        public Task CreateAsync(EnderecoFuncionariosEmpresa endereco, int idFuncionario)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnderecoFuncionariosEmpresa>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoFuncionariosEmpresa> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EnderecoFuncionariosEmpresa endereco, int idFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
