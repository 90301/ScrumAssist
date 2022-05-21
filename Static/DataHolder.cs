using ScrumAssist.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumAssist.Static
{
    public static class DataHolder
    {

        public static BindingList<Team> AllTeams = new BindingList<Team>();
        public static BindingList<Developer> DevelopersOnTeam = new BindingList<Developer>();

        /// <summary>
        /// Move this to a config file
        /// </summary>
        public static string connString = @"Address=localhost;Integrated Security=True; Connect Timeout=30";
        public static SqlConnection sql = new SqlConnection(connString);
        public static void ConnectToSqlDatabase()
        {
            //SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
            
            sql.Open();
        }

        public static void DisconnectSql()
        {
            sql.Close();
        }

        public static void addTeam(Team currentTeam)
        {
            AllTeams.Add(currentTeam);
        }

        internal static void addDeveloper(Developer currentDeveloper)
        {
            throw new NotImplementedException();
        }
    }
}
