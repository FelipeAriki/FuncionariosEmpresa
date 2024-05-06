using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Data
{
    public class EntrevistaFuncionariosEmpresaRepository
    {
        private readonly IDbConnection _connection;

        public EntrevistaFuncionariosEmpresaRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }
    }
}
