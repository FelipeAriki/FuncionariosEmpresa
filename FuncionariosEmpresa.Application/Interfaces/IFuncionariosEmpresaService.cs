using FuncionariosEmpresa.Domain.Entities;

namespace FuncionariosEmpresa.Application.Interfaces
{
    public interface IFuncionariosEmpresaService
    {
        public Task<IEnumerable<FuncionarioEmpresa>> GetAllAsync();
        public Task<FuncionarioEmpresa> GetByIdAsync(int id);
        public Task CreateAsync(FuncionarioEmpresa funcionario);
        public Task UpdateAsync(FuncionarioEmpresa funcionario);
        public Task DeleteAsync(int id);
    }
}
