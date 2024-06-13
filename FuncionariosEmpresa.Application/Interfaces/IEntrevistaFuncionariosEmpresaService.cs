using FuncionariosEmpresa.Domain.Entities;

namespace FuncionariosEmpresa.Application.Interfaces
{
    public interface IEntrevistaFuncionariosEmpresaService
    {
        public Task<IEnumerable<EntrevistaFuncionariosEmpresa>> GetAllAsync();
        public Task<EntrevistaFuncionariosEmpresa> GetByIdAsync(int id);
        public Task CreateAsync(EntrevistaFuncionariosEmpresa entrevista);
        public Task UpdateAsync(EntrevistaFuncionariosEmpresa entrevista);
        public Task DeleteAsync(int id);
    }
}
