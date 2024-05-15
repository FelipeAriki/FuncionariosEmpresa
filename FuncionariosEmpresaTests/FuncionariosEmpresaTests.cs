using FuncionariosEmpresa.Data.Repositories;
using FuncionariosEmpresa.Domain.Entities;
using FuncionariosEmpresa.Domain.Interfaces;
using System.Data.Common;
using System.Data;
using Xunit;

namespace FuncionariosEmpresaTests
{
    public class FuncionariosEmpresaTests
    {
        private readonly IDbConnection _connection;
        public FuncionariosEmpresaTests(IDbConnection connection)
        {
            _connection = connection;
        }

        [Fact]
        public async Task GetAllAsyncFuncionarios()
        {
            //Arrange = Definir variáveis
            FuncionariosEmpresaRepository funcionario = new(_connection);

            //Act = Fazer ação com as variáveis que irão gerar um resultado
            var resultado = await funcionario.GetAllAsync();

            //Assert = Validar resultados
            Assert.NotNull( resultado );
        }

        [Fact]
        public async Task GetAllAsyncEntrevistas()
        {
            //Arrange
            EntrevistaFuncionariosEmpresaRepository entrevista = new(_connection);
            //Act
            var resultado = await entrevista.GetAllAsync();

            //Assert
            Assert.NotNull ( resultado );
        }

        [Fact]
        public async Task GetAllAsyncEnderecos()
        {
            //Arrange
            EnderecoFuncionariosEmpresaRepository endereco = new(null, _connection);

            //Act
            var response = await endereco.GetAllAsync();

            //Assert
            Assert.NotNull( response );
        }
    }
}
