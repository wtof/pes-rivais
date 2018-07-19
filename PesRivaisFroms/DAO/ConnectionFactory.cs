using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PesRivaisForms.DAO
{
    class  ConnectionFactory
    {

        private static MySqlConnection istance;    
        private static readonly string connString = "Server=localhost;Database=payfast;Uid=root;Pwd=admin;SslMode=none";

     
        public static MySqlConnection ConnectionIstance()
        {
            try
            {
                if (istance == null)
                {
                    istance = new MySqlConnection(connString);
                }
            }
            catch (Exception e )
            {
                throw e;
            }
            
            return istance;
        }

        public static void Close()
        {
            try
            {
                if (!ConnectionIstance().State.Equals("Close"))
                {
                    ConnectionIstance().Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao tentar fechar conexão", e);
            }
        }


        public static void Open()
        {
            try
            {
                if (!ConnectionIstance().State.Equals("Open"))
                {
                    ConnectionIstance().Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao tentar abrir conexão", e);
            }
        }

       /* public static void Main(string[] args)
        {
           ParticipanteDAO dao =  new ParticipanteDAO();
           List <Participante> participantes = dao.BuscaTodosPartipantes();

            foreach (Participante p in participantes)
            {
                //MessageBox.Show(p.Nome);
            }

            Participante participante = participantes.ElementAt<Participante>(0);
            participante.Pontos = 3;


            int result = dao.AtualizaPartipantes(participante);
            MessageBox.Show(""+ result);
    
        }*/
    }
}
