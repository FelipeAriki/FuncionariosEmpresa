using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuncionariosEmpresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoFuncionariosEmpresaController : ControllerBase
    {
        private readonly IEnderecoFuncionariosEmpresaService _enderecoFuncionariosEmpresaService;
        public EnderecoFuncionariosEmpresaController(IEnderecoFuncionariosEmpresaService enderecoFuncionariosEmpresaService)
        {
            _enderecoFuncionariosEmpresaService = enderecoFuncionariosEmpresaService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var resultado = await _enderecoFuncionariosEmpresaService.GetAllAsync();
            return resultado == null || !resultado.Any() ? Ok(new List<EnderecoFuncionariosEmpresa>()) : Ok(resultado);
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var resultado = await _enderecoFuncionariosEmpresaService.GetByIdAsync(id);
            return resultado == null ? Ok(new List<EnderecoFuncionariosEmpresa>()) : Ok(resultado);
        }

        [HttpPost("CreateAsync")]
        public async Task<IActionResult> CreateAsync(EnderecoFuncionariosEmpresa endereco, int idFuncionario)
        {
            await _enderecoFuncionariosEmpresaService.CreateAsync(endereco, idFuncionario);
            return Created();
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(EnderecoFuncionariosEmpresa endereco, int idFuncionario)
        {
            await _enderecoFuncionariosEmpresaService.UpdateAsync(endereco, idFuncionario);
            return Ok(new {Mensagem = "Endereço Atualizado com sucesso!"});
        }

        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _enderecoFuncionariosEmpresaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
