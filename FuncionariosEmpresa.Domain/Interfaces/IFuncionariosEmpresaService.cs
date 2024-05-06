using FuncionariosEmpresa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Domain.Interfaces
{
    public interface IFuncionariosEmpresaService
    {
        public Task<IEnumerable<FuncionarioEmpresa>> GetAllAsync();
        public Task<FuncionarioEmpresa> GetAsync();
        public Task CreateAsync(FuncionarioEmpresa funcionario);
        public Task UpdateAsync(FuncionarioEmpresa funcionario);
        public Task DeleteAsync(int id);
    }
}
