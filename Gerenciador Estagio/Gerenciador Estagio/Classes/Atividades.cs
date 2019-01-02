using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Estagio.Classes
{
    public class Atividades
    {
        public int ID_ATIVIDADE { get; set; }
        public DateTime DataAtividade { get; set; }
        public string Titulo_Atividade { get; set; }
        public string Setor_Atuado { get; set; }
        public string Descricao_Problema { get; set; }
        public string Descricao_Solucao { get; set; }
        public string Estado { get; set; }
    }
}
