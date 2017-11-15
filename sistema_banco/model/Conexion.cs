using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.SqlClient;

namespace sistema_banco.model {
    public class Conexion {
        private SqlConnection con; // Connection
        private SqlCommand sen; // Statement
        public SqlDataReader rs; // ResultSet

        public Conexion(String bd) {
            con = new SqlConnection(
                    "Data Source=DESKTOP-TC26VSD\\SQLEXPRESS;" +
                    "Initial Catalog=" + bd + "; " +
                    "User id=sa; " +
                    "Password=123456;"
                );

            /*
            Autenticación de windows

            "Data Source=ServerName;" +
            "Initial Catalog=DataBaseName;" +
            "Integrated Security=SSPI;";
            */

            // url de conexión
        }

        public void Ejecutar(String query) {
            Console.WriteLine("QUERY=" + query);

            con.Open();
            sen = new SqlCommand(query, con);

            if (query.ToLower().Contains("select")) {
                rs = sen.ExecuteReader();
            } else { //insert, update, delete
                sen.ExecuteNonQuery();
                Cerrar();
            }
        }

        public void Cerrar() {
            con.Close();
        }
    }
}
}