using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Domain.Entities
{
    public class EntrevistaFuncionariosEmpresa
    {
        public int Id { get; set; }
        public string? Empresa { get; set; }
        public DateTime DataEntrevista { get; set; }
        public float Salario { get; set; }
        public string? ResponsavelVaga { get; set; }
    }
}
