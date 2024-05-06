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

        //TODO: FAZER CRUD
    }
}
