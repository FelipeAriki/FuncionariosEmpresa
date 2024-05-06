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
        public Task<EntrevistaFuncionariosEmpresa> GetAsync();
        public Task CreateAsync(EntrevistaFuncionariosEmpresa entrevistas);
        public Task UpdateAsync(EntrevistaFuncionariosEmpresa entrevistas);
        public Task DeleteAsync(int id);
    }
}
