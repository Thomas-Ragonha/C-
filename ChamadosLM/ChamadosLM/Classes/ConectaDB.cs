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

        public void VerificaUsuario(string query)
        {
            SetConnection();
            sqlCon.Open();
            sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = query;
            SQLiteDataReader sqReader = sqlCommand.ExecuteReader();
            string dt;
            while (sqReader.Read())
            {
                dt = sqReader[1].ToString();
                dt = sqReader[2].ToString();
                dt = sqReader[0].ToString();
                dt = sqReader[2].ToString();
            }
            sqlCommand.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
