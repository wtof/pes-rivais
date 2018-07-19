using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesRivaisForms.Totalizador;

namespace PesRivaisForms.DAO
{
    class Participante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Vitorias { get; set; }
        public int Empate { get; set; }
        public int Derrota { get; set; }
        public int Pontos { get; set; }
        public int Jogos { get; set; }

        private int golsPro = 0;
        private int golsContra =0;

        public int SaldoGols {
            get
            {
                return GolsPro - GolsContra;
            }
        }

        public int GolsPro {
            get
            {
                return this.golsPro;
            }
            set
            {
               this.golsPro += value;
            }
        }
        public int GolsContra
        {
            get
            {
                return this.golsContra;
            }
            set
            {
                golsContra += value;
            }
        }
        


        public Participante(string nome)
        {
            Nome = nome;
        }

        public void TotalizaPontuacao(TotalizadorPontos totalizador)
        {
            totalizador.GerenciaPontuacao(this);
        }

    }
}
