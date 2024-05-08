using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Application.Services
{
    public class EntrevistaFuncionariosEmpresaService : IEntrevistaFuncionariosEmpresaService
    {
        private readonly IEntrevistaFuncionariosEmpresaRepository _entrevistaFuncionariosEmpresaRepository;
        public EntrevistaFuncionariosEmpresaService(IEntrevistaFuncionariosEmpresaRepository entrevistaFuncionariosEmpresaRepository)
        {
            _entrevistaFuncionariosEmpresaRepository = entrevistaFuncionariosEmpresaRepository;
        }

        public async Task CreateAsync(EntrevistaFuncionariosEmpresa entrevista)
        {
            await _entrevistaFuncionariosEmpresaRepository.CreateAsync(entrevista);
        }

        public async Task DeleteAsync(int id)
        {
            await _entrevistaFuncionariosEmpresaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EntrevistaFuncionariosEmpresa>> GetAllAsync()
        {
            return await _entrevistaFuncionariosEmpresaRepository.GetAllAsync();
        }

        public async Task<EntrevistaFuncionariosEmpresa> GetByIdAsync(int id)
        {
            return await _entrevistaFuncionariosEmpresaRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(EntrevistaFuncionariosEmpresa entrevista)
        {
            await _entrevistaFuncionariosEmpresaRepository.UpdateAsync(entrevista);
        }
    }
}
