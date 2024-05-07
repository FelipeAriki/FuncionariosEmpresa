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
        private readonly IFuncionariosEmpresaRepository _funcionariosEmpresaRepository;

        public FuncionariosEmpresaService(IFuncionariosEmpresaRepository funcionariosEmpresaRepository)
        {
            _funcionariosEmpresaRepository = funcionariosEmpresaRepository;
        }

        public async Task CreateAsync(FuncionarioEmpresa funcionario)
        {
            await _funcionariosEmpresaRepository.CreateAsync(funcionario);
        }

        public async Task DeleteAsync(int id)
        {
            await _funcionariosEmpresaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<FuncionarioEmpresa>> GetAllAsync()
        {
            return await _funcionariosEmpresaRepository.GetAllAsync();
        }
        public async Task<FuncionarioEmpresa> GetByIdAsync(int id)
        {
            return await _funcionariosEmpresaRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(FuncionarioEmpresa funcionario)
        {
            await _funcionariosEmpresaRepository.UpdateAsync(funcionario);
        }
    }
}
