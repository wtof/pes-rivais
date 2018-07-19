using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesRivaisForms.DAO;

namespace PesRivaisForms.Totalizador
{
    class TotalizadorPontosDerrota : TotalizadorPontos
    {
        public TotalizadorPontosDerrota()
        {
            this.Nome = "DERROTA";
        }

        public override void GerenciaPontuacao(Participante participante)
        {
            participante.Derrota += 1;
            participante.Jogos += 1;
        }
    }
}
