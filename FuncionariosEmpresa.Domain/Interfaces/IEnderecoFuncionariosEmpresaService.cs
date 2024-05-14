using FuncionariosEmpresa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Domain.Interfaces
{
    public interface IEnderecoFuncionariosEmpresaService
    {
        public Task<IEnumerable<EnderecoFuncionariosEmpresa>> GetAllAsync();
        public Task<EnderecoFuncionariosEmpresa> GetByIdAsync(int id);
        public Task CreateAsync(EnderecoFuncionariosEmpresa endereco);
        public Task UpdateAsync(EnderecoFuncionariosEmpresa endereco);
        public Task DeleteAsync(int id);
    }
}
