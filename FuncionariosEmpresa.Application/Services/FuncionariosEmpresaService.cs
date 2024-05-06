using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Application.Services
{
    public class FuncionariosEmpresaService : IFuncionariosEmpresaService
    {
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
        public Task<FuncionarioEmpresa> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(FuncionarioEmpresa funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
