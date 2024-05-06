using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Domain.Entities
{
    public class EnderecoFuncionariosEmpresa
    {
        public int IdFuncionario { get; set; }
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
    }
}
