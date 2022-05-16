using ScrumAssist.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAssist.Static
{
    public static class DataHolder
    {

        public static List<Team> AllTeams = new List<Team>();
        public static List<Developer> DevelopersOnTeam = new List<Developer>();

        /// <summary>
        /// Move this to a config file
        /// </summary>
        public static string connString = @"Address=localhost;Integrated Security=True; Connect Timeout=30";

        public static void ConnectToSqlDatabase()
        {
            //SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
            SqlConnection sql = new SqlConnection(connString);
            sql.Open();




            sql.Close();
        }
    }
}
