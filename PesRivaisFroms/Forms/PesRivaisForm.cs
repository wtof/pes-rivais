using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PesRivaisForms.DAO;
using PesRivaisForms.Totalizador;

namespace PesRivaisForms
{
    public partial class PesRivaisForm : Form
    {

        int[] gols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<Participante> participantes;
        int golsPro;
        int golsContra;
        Boolean init = true;
        TotalizadorPontos totalizador;
        ParticipanteDAO dao = new ParticipanteDAO();


        public PesRivaisForm()
        {
            InitializeComponent();
        }

        private void PesRivaisForm_Load(object sender, EventArgs e)
        {
            participantes = CarregaParticipante();

            //Carrega combo participantes
            CarregaComboParticipantes();

            //Carrega combo pontos
            CarregaComboPontos();

            //Carrega combo gol pro
            CarregaCombosGolPro();

            //Carrega combo gol contra
            CarregaCombosGolContra();

            //Carrega primeira coluna da grid
            CarregaParticipantesGrid();
        }

        private void CarregaCombosGolPro()
        {
            golProCb.Items.Add("Selecione");
            //Carrega combos gols
            foreach (int gol in gols)
            {
                golProCb.Items.Add(gol);
            }
        }

        private void CarregaCombosGolContra()
        {
            golContraCb.Items.Add("Selecione");
            //Carrega combos gols
            foreach (int gol in gols)
            {
                golContraCb.Items.Add(gol);
            }
        }

        private void pontosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void particpantesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Participante participante = (Participante)particpantesCb.SelectedItem;

            //Pesquisar para arrumar depois(quando carrega o form dispara esse evento
            if (!init)
            {
                pontosCb.Enabled = true;
                pontosCb.Text = "Selecione";
                golContraCb.Text = "Selecione";
                golProCb.Text = "Selecione";
                golContraCb.Enabled = false;
                golProCb.Enabled = false;
                DesabilitaAdicionar();
            }
            else
            {
                init = false;
            }
        }

        //Pontos selecionado
        private void pontosCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalizador = (TotalizadorPontos)pontosCb.SelectedItem;

            golProCb.Enabled = true;
            golContraCb.Text = "Selecione";
            golProCb.Text = "Selecione";
            golContraCb.Enabled = false;
        }

        //Gol pro selecionado
        private void golProCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (golProCb.SelectedIndex != 0)
            {
                golsPro = (int)golProCb.SelectedItem;
                golContraCb.Text = "Selecione";

                ValidaGolsProVitoria();

                ValidaGolsProEmpate();
            }
        }

        private void ValidaGolsProEmpate()
        {
            //Se empate gols adiciona o valor valor para gols contra e bloquea alteração
            if (totalizador.Nome.Equals("EMPATE"))
            {
                golContraCb.SelectedIndex = golProCb.SelectedIndex;
                golContraCb.Enabled = false;
                HabilitaAdicionar();
            }
            else
            {
                golContraCb.Enabled = true;
            }
        }

        private void ValidaGolsProVitoria()
        {
            if (totalizador.Nome.Equals("VITORIA"))
            {
                if (golsPro == 0)
                {
                    MessageBox.Show("Na vitória gols pró não pode ser zero.");
                    golContraCb.Enabled = false;
                    golProCb.Text = "Selecione";
                }
            }
        }

        //Gol contra selecionado
        private void golContraCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (golContraCb.SelectedIndex != 0)
            {
                golsContra = (int)golContraCb.SelectedItem;

                ValidaGolsVitoria();

                ValidaGolsDerrota();
            }

        }

        private void ValidaGolsDerrota()
        {
            if (totalizador.Nome.Equals("DERROTA"))
            {
                if (golsContra <= golsPro)
                {
                    golContraCb.Text = "Selecione";
                    MessageBox.Show("Na Derrota gol contra não pode ser menor ou igual ao gol pró. " +
                        "Por favor selecione outro valor.");

                    golContraCb.Text = "Selecione";
                    DesabilitaAdicionar();
                }
                else
                {
                    HabilitaAdicionar();
                }
            }
        }

        private void ValidaGolsVitoria()
        {
            if (totalizador.Nome.Equals("VITORIA"))
            {
                if (golsContra >= golsPro)
                {
                    MessageBox.Show("Na Vitória gol contra não pode ser maior ou igual ao gol pró. " +
                        "Por favor selecione outro valor." + golContraCb.SelectionStart);

                    golContraCb.Text = "Selecione";
                    DesabilitaAdicionar();
                }
                else
                {
                    HabilitaAdicionar();
                }
            }
        }

        private List<Participante> CarregaParticipante()
        {
            participantes = dao.BuscaTodosPartipantes();
            return participantes;
        }

        //Carrega combo participantes
        private void CarregaComboParticipantes()
        {
            particpantesCb.DisplayMember = "Nome";
            particpantesCb.DataSource = participantes;
            particpantesCb.Text = "Selecione";
        }

        //Carrega campos
        private void CarregaComboPontos()
        {
            pontosCb.DisplayMember = "Nome";
            pontosCb.Items.Add(new TotalizadorPontosVitoria());
            pontosCb.Items.Add(new TotalizadorPontosEmpate());
            pontosCb.Items.Add(new TotalizadorPontosDerrota());
        }

        //Popula primeira grid da tabela
        private void CarregaParticipantesGrid()
        {
            this.pontosGridView.Rows.Clear();

            //participantes = participantes.OrderByDescending(p => p.Pontos).ToList();

            foreach (Participante participante in participantes)
            {
                this.pontosGridView.Rows.Add(participante.Nome, participante.Pontos, participante.Jogos,
                participante.Vitorias, participante.Empate, participante.Derrota, participante.GolsPro,
                participante.GolsContra, participante.SaldoGols);
            }

            CarregaListViewTop3();
        }

        private void CarregaListViewTop3()
        {
            this.listViewTop3.Clear();
            this.listViewTop3.Items.Add("1°: " + participantes.ElementAt<Participante>(0).Nome + "  /Pontos: " + participantes.ElementAt<Participante>(0).Pontos);
            this.listViewTop3.Items.Add("2°: " + participantes.ElementAt<Participante>(1).Nome + "  /Pontos: " + participantes.ElementAt<Participante>(1).Pontos);
            this.listViewTop3.Items.Add("3°: " + participantes.ElementAt<Participante>(2).Nome + "  /Pontos: " + participantes.ElementAt<Participante>(2).Pontos);
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            Participante participante = (Participante)particpantesCb.SelectedItem;
            participante.GolsPro = golsPro;
            participante.GolsContra = golsContra;

            TotalizadorPontos totalizador = (TotalizadorPontos)pontosCb.SelectedItem;
            participante.TotalizaPontuacao(totalizador);

            dao.AtualizaPartipantes(participante);
            participantes = dao.BuscaTodosPartipantes();

            CarregaParticipantesGrid();
            ResetaCampos();
        }

        private void ResetaCampos()
        {
            particpantesCb.Text = "Selecione";
            pontosCb.Text = "Selecione";
            pontosCb.Enabled = false;
            golProCb.Text = "Selecione";
            golProCb.Enabled = false;
            golContraCb.Text = "Selecione";
            golContraCb.Enabled = false;
            DesabilitaAdicionar();
        }

        private void HabilitaAdicionar()
        {
            adicionarBtn.Enabled = true;
        }

        private void DesabilitaAdicionar()
        {
            adicionarBtn.Enabled = false;
        }

    }
}
