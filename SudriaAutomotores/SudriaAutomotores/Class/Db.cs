using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SudriaAutomotores.Class
{
    internal class Db
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "127.0.0.1"; //Nombre o ip del servidor de MySQL
        static string baseD = "sudriaautomotores"; //Nombre de la base de datos
        static string usuario = "root"; //Usuario de acceso a MySQL
        static string password = "root"; //Contraseña de usuario de acceso a MySQL
        static string puerto = "3306"; //Puerto de acceso MySQL
        string cadenaConexion = "Database=" + baseD + "; Server=" + servidor + "; User Id=" + usuario + "; Password=" + password + "; port=" + puerto + ";";


        public MySqlConnection startConnection()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar a la base");
            }
            return conex;
        }

        public void endConnection()
        {
            conex.Close();
        }
    }
}
