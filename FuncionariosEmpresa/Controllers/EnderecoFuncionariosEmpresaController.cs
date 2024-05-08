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


    }
}
