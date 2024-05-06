using FuncionariosEmpresa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Domain.Interfaces
{
    public interface IEntrevistaFuncionariosEmpresaService
    {
        public Task<IEnumerable<EntrevistaFuncionariosEmpresa>> GetAllAsync();
        public Task<EntrevistaFuncionariosEmpresa> GetAsync(int id);
        public Task CreateAsync(EntrevistaFuncionariosEmpresa entrevista);
        public Task UpdateAsync(EntrevistaFuncionariosEmpresa entrevista);
        public Task DeleteAsync(int id);
    }
}
