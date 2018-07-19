using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PesRivaisForms.DAO
{
    class ParticipanteDAO
    {
        private MySqlConnection connection;

        public ParticipanteDAO()
        {
            try
            {
                connection = ConnectionFactory.ConnectionIstance();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível estabelecer conexão com a base de dados: " + e.Message);
            }
            
        }

        public List <Participante> BuscaTodosPartipantes()
        {

            List<Participante> partipantes = new List<Participante>();
            MySqlDataReader reader;

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM PARTICIPANTE";

            try
            {
                ConnectionFactory.Open();
                reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Participante participante = new Participante(reader["nome"].ToString());
                    participante.Id =  Convert.ToInt32(reader["id"]);
                    participante.Pontos = (int)reader["pontos"];
                    participante.Jogos = (int)reader["jogos"];
                    participante.Vitorias = (int)reader["vitorias"];
                    participante.Empate = (int)reader["empates"];
                    participante.Derrota = (int)reader["derrotas"];
                    participante.GolsPro = (int)reader["gols_pro"];
                    participante.GolsContra = (int)reader["gols_contra"];

                    partipantes.Add(participante);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao tentar bucar os participantes na base de dados", e);
            }

            finally
            {
                ConnectionFactory.Close();

            }   
            return OrdenaPorPontosGols(partipantes);
        }

        public int AtualizaPartipantes(Participante participante)
        {


            int result = 0;

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE participante SET " +
                "nome=@nome, " +
                "pontos=@pontos, " +
                "jogos=@jogos, " +
                "vitorias=@vitorias, " +
                "empates=@empates, " +
                "derrotas=@derrotas, " +
                "gols_pro=@gols_pro, " +
                "gols_contra=@gols_contra, " +
                "saldo_gols=@saldo_gols " +
                "WHERE id=@id";

            command.Parameters.Add(new MySqlParameter("@nome", participante.Nome));
            command.Parameters.Add(new MySqlParameter("@pontos", participante.Pontos));
            command.Parameters.Add(new MySqlParameter("@jogos", participante.Jogos));
            command.Parameters.Add(new MySqlParameter("@vitorias", participante.Vitorias));
            command.Parameters.Add(new MySqlParameter("@empates", participante.Empate));
            command.Parameters.Add(new MySqlParameter("@derrotas", participante.Derrota));
            command.Parameters.Add(new MySqlParameter("@gols_pro", participante.GolsPro));
            command.Parameters.Add(new MySqlParameter("@gols_contra", participante.GolsContra));
            command.Parameters.Add(new MySqlParameter("@saldo_gols", participante.SaldoGols));
            command.Parameters.Add(new MySqlParameter("@id", participante.Id));

            try
            {
                ConnectionFactory.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(
                    "Erro ao tentar atualizar o participante ID: " + participante.Id + " na base de dados", e);
            }

            finally
            {
                ConnectionFactory.Close();
            }

            return result;
        }

        /**
         * Metodo responsável por ordenar uma lista de participantes utilizando linq.
         **/ 
        private List<Participante> OrdenaPorPontosGols(List <Participante> participantes)
        {
            var query = from p in participantes
                            orderby p.Pontos descending, p.SaldoGols descending
                        select p;
            participantes = query.ToList<Participante>();
            return participantes;
        }
    }
}
