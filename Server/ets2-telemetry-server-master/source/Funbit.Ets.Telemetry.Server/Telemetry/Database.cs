using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Funbit.Ets.Telemetry.Server.Telemetry
{
    class Database
    {
        private string connectionString = @"Data Source = Data\\DataBase.db; Version = 3"; //Database Path

        public bool ifExist() //Verify if database exist 
        {
            if (!File.Exists("Data\\DataBase.db"))
            {
                makeDb();
                return true;
            }
            else return false;
        }

        public static void makeDb()// Create a database 
        {
            try
            {
                if (!Directory.Exists("Data"))
                {
                    Directory.CreateDirectory("Data");
                }
                SQLiteConnection.CreateFile("Data\\DataBase.db");
                SQLiteConnection conn = new SQLiteConnection("Data Source= Data\\DataBase.db");
                SQLiteCommand command = new SQLiteCommand(conn);
                string caminho = conn.DataSource;
                conn.Open();
                command.CommandText = "CREATE TABLE [Table01] ([ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,[Speed] NVARCHAR(50) NOT NULL,[Gear] NVARCHAR(50) NOT NULL);";
                int i = command.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception e)
            {

            }

        }

        public void writeDb(int speed, int gear)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = @"INSERT INTO Table01 (Speed,Gear) VALUES (@Speed,@Gear)";
                cmd.Connection = con;
                cmd.Parameters.Add(new SQLiteParameter("@Speed", speed));
                cmd.Parameters.Add(new SQLiteParameter("@Gear", gear));
                con.Open();
                int i = cmd.ExecuteNonQuery();
            }

        }
    }
}
