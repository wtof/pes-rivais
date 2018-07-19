using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesRivaisForms.DAO;

namespace PesRivaisForms.Totalizador
{
    class TotalizadorPontosEmpate : TotalizadorPontos
    {
        public TotalizadorPontosEmpate()
        {
            this.Nome = "EMPATE";
        }

        public override void GerenciaPontuacao(Participante participante)
        {
            participante.Empate += 1;
            participante.Pontos += 1;
            participante.Jogos += 1;
        }
    }
}
