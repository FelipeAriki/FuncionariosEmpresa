using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using Xunit;

namespace FuncionariosEmpresaTests
{
    public class FuncionariosEmpresaTests
    {
        private readonly IEnderecoFuncionariosEmpresaRepository _enderecoFuncionariosEmpresaRepository;
        private readonly IEntrevistaFuncionariosEmpresaRepository _entrevistaFuncionariosEmpresaRepository;
        private readonly IFuncionariosEmpresaRepository _funcionariosEmpresaRepository;

        public FuncionariosEmpresaTests(
            IEnderecoFuncionariosEmpresaRepository enderecoFuncionariosEmpresaRepository,
            IEntrevistaFuncionariosEmpresaRepository entrevistaFuncionariosEmpresaRepository,
            IFuncionariosEmpresaRepository funcionariosEmpresaRepository
            )
        {
            _enderecoFuncionariosEmpresaRepository = enderecoFuncionariosEmpresaRepository;
            _entrevistaFuncionariosEmpresaRepository = entrevistaFuncionariosEmpresaRepository;
            _funcionariosEmpresaRepository = funcionariosEmpresaRepository;
        }

        [Fact]
        public async Task GetAllAsyncFuncionarios()
        {
            //Arrange = Definir variáveis
            

            //Act = Fazer ação com as variáveis que irão gerar um resultado
            var resultado = await _funcionariosEmpresaRepository.GetAllAsync();

            //Assert = Validar resultados
            Assert.NotNull( resultado );
        }

        [Fact]
        public async Task GetAllAsyncEntrevistas()
        {
            //Arrange

            //Act
            var resultado = await _entrevistaFuncionariosEmpresaRepository.GetAllAsync();

            //Assert
            Assert.NotNull ( resultado );
        }

        [Fact]
        public async Task GetAllAsyncEnderecos()
        {
            //Arrange

            //Act
            var response = await _enderecoFuncionariosEmpresaRepository.GetAllAsync();

            //Assert
            Assert.NotNull( response );
        }
    }
}
