using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuncionariosEmpresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrevistaFuncionariosEmpresaController : ControllerBase
    {
        private readonly IEntrevistaFuncionariosEmpresaService _entrevistasFuncionariosEmpresaService;

        public EntrevistaFuncionariosEmpresaController(IEntrevistaFuncionariosEmpresaService entrevistasFuncionariosEmpresaService)
        {
            _entrevistasFuncionariosEmpresaService = entrevistasFuncionariosEmpresaService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var resultado = await _entrevistasFuncionariosEmpresaService.GetAllAsync();
            return resultado == null || !resultado.Any() ? Ok(new List<EntrevistaFuncionariosEmpresa>()) : Ok(resultado);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var resultado = await _entrevistasFuncionariosEmpresaService.GetAsync(id);
            return resultado == null ? Ok(new List<EntrevistaFuncionariosEmpresa>()) : Ok(resultado);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(EntrevistaFuncionariosEmpresa entrevista)
        {
            await _entrevistasFuncionariosEmpresaService.CreateAsync(entrevista);
            return Created();
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> DeleteAsync([FromQuery] int id)
        {
            await _entrevistasFuncionariosEmpresaService.DeleteAsync(id);
            return NoContent();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync(EntrevistaFuncionariosEmpresa entrevista)
        {
            await _entrevistasFuncionariosEmpresaService.UpdateAsync(entrevista);
            return Ok(entrevista);
        }
         
    }
}
