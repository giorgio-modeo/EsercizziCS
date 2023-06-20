using System.Data;
using System.Data.SqlClient;

namespace ConnessioneDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("connessione al database MS SQL server!");

            //accesso al db
            //backend:Its-2023
            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            connection.DataSource = @".\MSSQLSERVER01";//dbms
            connection.UserID = "backend";
            connection.Password = "Its-2023";
            connection.InitialCatalog = "Anagrafica";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connection.ConnectionString;
            sqlConnection.Open();
            Console.WriteLine("connessione riusita");

            //interrogazzione db
            Console.WriteLine("inserisci la classe");
            string classe = Console.ReadLine();
            string sql = $"select * from Studenti where Classe = '{classe}'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            // uso di parametri
            //cmd.Parameters.Add("@classe", SqlDbType.VarChar,10).Value=classe;
            //cmd.CreateParameter();


            SqlDataReader sdr = cmd.ExecuteReader();

            //visualizzare i dati 
            while (sdr.Read())
            {
                Console.Write("Matricola: "+sdr.GetInt16(0));
                Console.Write(";Nome: "+sdr.GetString(1));
                Console.Write(";Cogniome: "+sdr.GetString(2));
                Console.Write(";Email: "+sdr.GetString(3));
                Console.WriteLine(";Classe: "+sdr.GetString(4));

            }
            //chiudo connessione
            sdr.Close();
            sqlConnection.Close();

        }
    }
}