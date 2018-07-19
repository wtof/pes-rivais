using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesRivaisForms.DAO;

namespace PesRivaisForms.Totalizador
{
    class TotalizadorPontosVitoria : TotalizadorPontos
    {
        public TotalizadorPontosVitoria()
        {
            this.Nome = "VITORIA";
        }

        public override void GerenciaPontuacao(Participante participante)
        {
            participante.Vitorias += 1;
            participante.Pontos += 3;
            participante.Jogos += 1;
        }
    }
}
