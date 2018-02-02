using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace ChamadosLM.Classes
{
    public class ConectaDB
    {
        private SQLiteConnection sqlCon;
        private SQLiteCommand sqlCommand;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sqlCon = new SQLiteConnection("Data Source=C:\\Users\\thomas.rivera\\Desktop\\C#\\SqLiteStudio\\SuporteDB.db;Version=3;");
        }

        public void ExecuteQuery(string query)
        {
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            sqlCon.Close();
        }

        public Usuarios VerificaUsuario(string query)
        {
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = query;
            SQLiteDataReader sqReader = sqlCommand.ExecuteReader();
            Usuarios usuarioLogin = new Usuarios();
            if (sqReader.HasRows)
            {
                while (sqReader.Read())
                {
                    usuarioLogin.ID = sqReader.GetInt32(0);
                    usuarioLogin.NomeUsuario = sqReader.GetString(1);
                    usuarioLogin.Senha = sqReader.GetString(2);
                }
                sqReader.Close();
                sqlCon.Close();
                return usuarioLogin;
            }
            else
            {
                return usuarioLogin;
            }
        }

        public Usuarios GetUsuarioByID(int id)
        {
            Usuarios usuario = new Usuarios();
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText ="SELECT * FROM Usuarios where ID =" + id;
            SQLiteDataReader sqReader = sqlCommand.ExecuteReader();
            if (sqReader.HasRows)
            {
                while (sqReader.Read())
                {
                    usuario.ID = sqReader.GetInt32(0);
                    usuario.NomeUsuario = sqReader.GetString(1);
                    usuario.Senha = sqReader.GetString(2);
                }
            }
            return usuario;
        }

        public List<Chamado> GetChamadosPorUsuario(int id)
        {
            List<Chamado> listaDeChamados = new List<Chamado>();
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Chamado where IDUsuarioCriacaoChamado =" + id;
            SQLiteDataReader sqReader = sqlCommand.ExecuteReader();
            if (sqReader.HasRows)
            {
                while (sqReader.Read())
                {
                    Chamado chamado = new Chamado();
                    chamado.ID = sqReader.GetInt32(0);
                    chamado.DescricaoChamado = sqReader.GetString(1);
                    chamado.ResolucaoChamado = sqReader.GetValue(2).ToString();
                    chamado.DataCriacaoChamado = sqReader.GetString(3);
                    chamado.DataFechamentoChamado = sqReader.GetValue(4).ToString();
                    chamado.StatusChamado = sqReader.GetString(5);
                    chamado.IDUsuarioCriacaoChamado = sqReader.GetInt32(6);
                    listaDeChamados.Add(chamado);
                }
            }
            sqReader.Close();
            sqlCon.Close();
            return listaDeChamados;
        }

        public Chamado GetChamadoById(int id)
        {
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Chamado where ID =" + id;
            SQLiteDataReader sqReader = sqlCommand.ExecuteReader();
            if (sqReader.HasRows)
            {
              Chamado chamado = new Chamado();
                while (sqReader.Read())
                {
                    chamado.ID = sqReader.GetInt32(0);
                    chamado.DescricaoChamado = sqReader.GetString(1);
                    chamado.ResolucaoChamado = sqReader.GetValue(2).ToString();
                    chamado.DataCriacaoChamado = sqReader.GetString(3);
                    chamado.DataFechamentoChamado = sqReader.GetValue(4).ToString();
                    chamado.StatusChamado = sqReader.GetString(5);
                    chamado.IDUsuarioCriacaoChamado = sqReader.GetInt32(6);
                }
                sqReader.Close();
                sqlCon.Close();
                return chamado;
            }
            sqReader.Close();
            sqlCon.Close();
            return null;
        }

        public void ExcluirChamado(int id)
        {
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = "DELETE FROM Chamado where ID =" + id;
            sqlCommand.ExecuteNonQuery();
            sqlCon.Close();

        }

        public void AtualizaStatusChamado(int id)
        {
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = "UPDATE Chamado set StatusChamado = 'Em Atendimento' WHERE id=" + id;
            sqlCommand.ExecuteNonQuery();
            sqlCon.Close();
        }

        public void ResolucaoChamado(Chamado chamado)
        {
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = "UPDATE Chamado set StatusChamado = '" + chamado.StatusChamado + "', ResolucaoChamado = '" + chamado.ResolucaoChamado + "', DataFechamentoChamado = '" + chamado.DataFechamentoChamado + "' WHERE ID =" + chamado.ID;
            sqlCommand.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
