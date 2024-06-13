using FuncionariosEmpresa.Application.Interfaces;
using FuncionariosEmpresa.Application.Services;
using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuncionariosEmpresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosEmpresaController : ControllerBase
    {
        private readonly IFuncionariosEmpresaService _funcionariosEmpresaService;

        public FuncionariosEmpresaController(IFuncionariosEmpresaService funcionariosEmpresaService)
        {
            _funcionariosEmpresaService = funcionariosEmpresaService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var resultado = await _funcionariosEmpresaService.GetAllAsync();
            return resultado == null || !resultado.Any() ? Ok(new List<FuncionarioEmpresa>()) : Ok(resultado);
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var resultado = await _funcionariosEmpresaService.GetByIdAsync(id);
            return resultado == null ? Ok(new List<FuncionarioEmpresa>()) : Ok(resultado);
        }

        [HttpPost("CreateAsync")]
        public async Task<IActionResult> CreateAsync(FuncionarioEmpresa funcionario)
        {
            await _funcionariosEmpresaService.CreateAsync(funcionario);
            return Created();
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(FuncionarioEmpresa funcionario)
        {
            await _funcionariosEmpresaService.UpdateAsync(funcionario);
            return Ok(funcionario);
        }

        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _funcionariosEmpresaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
