using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Data
{
    public class FuncionariosEmpresaRepository
    {
        private readonly IDbConnection _connection;

        public FuncionariosEmpresaRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }
    }
}
