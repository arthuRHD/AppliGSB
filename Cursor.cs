using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Odbc;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GSB_visites
{
    public class Cursor
    {
        string dbType;
        bool end;
        MySqlConnection mysql_connection;
        MySqlCommand mysql_command;
        MySqlDataReader mysql_dataReader;

        OleDbConnection oleDb_connection;
        OleDbCommand oleDb_command;
        OleDbDataReader oleDb_dataReader;

        SqlConnection sqlServer_connection;
        SqlCommand sqlServer_command;
        SqlDataReader sqlServer_dataReader;


        public Cursor(string ch, string db)
        {
            dbType = db;
            switch (db)
            {
                case "sqlserver":
                    sqlServer_connection = new SqlConnection(ch);
                    sqlServer_connection.Open();
                    sqlServer_dataReader = null;
                    break;
                case "access":
                    oleDb_connection = new OleDbConnection(ch);
                    oleDb_connection.Open();
                    oleDb_dataReader = null;
                    break;
                case "mysql":
                    mysql_connection = new MySqlConnection(ch);
                    mysql_connection.Open();
                    mysql_dataReader = null;
                    break;
            }
        }

        public void suivant()
        {
            bool flag = false;
            if (!end)
            {
                switch (dbType)
                {
                    case "mysql":
                        flag = mysql_dataReader.Read();
                        break;
                    case "access":
                        flag = oleDb_dataReader.Read();
                        break;
                    case "sqlserver":
                        flag = sqlServer_dataReader.Read();
                        break;
                }
                if (!flag)
                    end = true;
                else
                    end = false;
            }
        }

        public void remplir(string request, DataSet ds, string tableName)
        {
            switch (dbType)
            {
                case "mysql":
                    if (mysql_connection != null)
                    {
                        MySqlDataAdapter mysql_dataAdapter = new MySqlDataAdapter(request, mysql_connection);
                        mysql_dataAdapter.Fill(ds, tableName);                        
                    }
                    break;
                case "access":
                    if (oleDb_connection != null)
                    {
                        OleDbDataAdapter oleDb_dataAdapter = new OleDbDataAdapter(request, oleDb_connection);
                        oleDb_dataAdapter.Fill(ds, tableName);
                    }                    
                    break;
                case "sqlserver":
                    if (sqlServer_connection != null)
                    {
                        SqlDataAdapter sqlServer_dataAdapter = new SqlDataAdapter(request, sqlServer_connection);
                        sqlServer_dataAdapter.Fill(ds, tableName);
                    }                    
                    break;
            }
                          
        }

        public bool reqSelect(string req)
        {
            try
            {
                switch (dbType)
                {
                    case "mysql":
                        mysql_command = new MySqlCommand(req, mysql_connection);
                        mysql_dataReader = mysql_command.ExecuteReader();
                        end = false;
                        if (!mysql_dataReader.Read())
                        {
                            return false;
                        }
                        suivant();
                        break;
                    case "sqlserver":
                        sqlServer_command = new SqlCommand(req, sqlServer_connection);
                        sqlServer_dataReader = sqlServer_command.ExecuteReader();
                        end = false;
                        if (!oleDb_dataReader.Read())
                        {
                            return false;
                        }
                        suivant();
                        break;
                    case "access":
                        oleDb_command = new OleDbCommand(req, oleDb_connection);
                        oleDb_dataReader = oleDb_command.ExecuteReader();
                        end = false;
                        if (!sqlServer_dataReader.Read())
                        {
                            return false;
                        }
                        suivant();
                        break;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }

        public bool reqAdmin(string req)
        {
            try
            {
                switch (dbType)
                {
                    case "mysql":
                        mysql_command = new MySqlCommand(req, mysql_connection);
                        mysql_command.ExecuteNonQuery();
                        break;
                    case "sqlserver":
                        sqlServer_command = new SqlCommand(req, sqlServer_connection);
                        sqlServer_command.ExecuteNonQuery();
                        break;
                    case "access":
                        oleDb_command = new OleDbCommand(req, oleDb_connection);
                        oleDb_command.ExecuteNonQuery();
                        break;
                }
                return true;
            }
            catch (Exception e)
            {
                string msgError = e.Message;
                MessageBox.Show(msgError);
                return false;
                throw;
            }
        }


        public object champ(string nomChamp)
        {
            object reader = null;
            switch (dbType)
            {
                case "mysql":
                    if (mysql_dataReader.HasRows)
                    {
                        reader = mysql_dataReader[nomChamp];
                    } else { throw new Exception("Pas de résultats"); }
                    break;
                case "access":
                    if (oleDb_dataReader.HasRows)
                    {
                        reader = oleDb_dataReader[nomChamp];
                    }
                    else { throw new Exception("Pas de résultats"); }
                    break;
                case "sqlserver":
                    if (sqlServer_dataReader.HasRows)
                    {
                        reader = sqlServer_dataReader[nomChamp];
                    }
                    else { throw new Exception("Pas de résultats"); }
                    break;
            }
            return reader;
        }

        public void fermer()
        {
            switch (dbType)
            {
                case "mysql":
                    if (mysql_dataReader != null) { mysql_dataReader.Close(); }
                    mysql_connection.Close();
                    break;
                case "access":
                    if (oleDb_dataReader != null) { oleDb_dataReader.Close(); }
                    oleDb_connection.Close();
                    break;
                case "sqlserver":
                    if (sqlServer_dataReader != null) { sqlServer_dataReader.Close(); }
                    sqlServer_connection.Close();
                    break;
            }
        }


        public bool fin()
        {
            return end;
        }
    }
}
