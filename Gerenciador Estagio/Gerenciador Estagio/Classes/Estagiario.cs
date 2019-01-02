using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Estagio.Classes
{
    public class Estagiario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string NomeCurso { get; set; }
        public int Periodo { get; set; }
        public DateTime DataInicio { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDesligamento { get; set; }
    }
}
