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
    }
}
