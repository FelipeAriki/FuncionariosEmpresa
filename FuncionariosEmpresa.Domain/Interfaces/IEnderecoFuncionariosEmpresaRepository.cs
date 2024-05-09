using FuncionariosEmpresa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Domain.Interfaces
{
    public interface IEnderecoFuncionariosEmpresaRepository
    {
        public Task<IEnumerable<EnderecoFuncionariosEmpresa>> GetAllAsync();
        public Task<EnderecoFuncionariosEmpresa> GetByIdAsync(int id);
        public Task CreateAsync(EnderecoFuncionariosEmpresa endereco, int idFuncionario);
        public Task UpdateAsync(EnderecoFuncionariosEmpresa endereco, int idFuncionario);
        public Task DeleteAsync(int id);
    }
}
