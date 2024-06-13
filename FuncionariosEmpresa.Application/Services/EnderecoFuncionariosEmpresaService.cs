using FuncionariosEmpresa.Application.Interfaces;
using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;

namespace FuncionariosEmpresa.Application.Services
{
    public class EnderecoFuncionariosEmpresaService : IEnderecoFuncionariosEmpresaService
    {
        private readonly IEnderecoFuncionariosEmpresaRepository _enderecoFuncionariosRepository;
        public EnderecoFuncionariosEmpresaService(IEnderecoFuncionariosEmpresaRepository enderecoFuncionariosRepository)
        {
            _enderecoFuncionariosRepository = enderecoFuncionariosRepository;
        }

        public async Task CreateAsync(EnderecoFuncionariosEmpresa endereco)
        {
            await _enderecoFuncionariosRepository.CreateAsync(endereco);
        }

        public async Task DeleteAsync(int id)
        {
            await _enderecoFuncionariosRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EnderecoFuncionariosEmpresa>> GetAllAsync()
        {
            return await _enderecoFuncionariosRepository.GetAllAsync();
        }

        public async Task<EnderecoFuncionariosEmpresa> GetByIdAsync(int id)
        {
            return await _enderecoFuncionariosRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(EnderecoFuncionariosEmpresa endereco)
        {
            await _enderecoFuncionariosRepository.UpdateAsync(endereco);
        }
    }
}
