using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesRivaisForms.DAO;

namespace PesRivaisForms.Totalizador
{
    abstract class  TotalizadorPontos
    {
        public string Nome { get; protected set; }
        public abstract void GerenciaPontuacao(Participante participante);
    }
}
