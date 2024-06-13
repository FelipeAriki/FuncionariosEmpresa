using FuncionariosEmpresa.Domain.Entities;

namespace FuncionariosEmpresa.Application.Interfaces
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
