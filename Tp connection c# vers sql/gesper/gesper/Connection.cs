using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace gesper
{
    public class Connection
    {
        MySqlConnection cnx;

        public MySqlConnection Cnx { get => cnx; set => cnx = value; }

        public Connection(string h, string user, string pwd, string bdd)
        {
            string sCnx;

            sCnx = String.Format("server={0};uid={1};database={2};port=3306;pwd={3}", h, user, bdd, pwd);

            cnx = new MySqlConnection(sCnx);
        }
        public string Ouvrir()
        {
            string message;
            try
            {
                cnx.Open();
                message ="connexion réussie";
            }
            catch (Exception e)
            {
                message = String.Format("Echec de la connexion {0}", e.Message);
            }
            return message;
        }
        public void Fermer()
        {
            cnx.Close();
        }
    }
}
