using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.SqlClient;

namespace sistema_banco.model
{
    public class Conexion
    {
        private SqlConnection con; // Connection
        private SqlCommand sen; // Statement
        public SqlDataReader rs; // ResultSet

        public Conexion(String bd)
        {
            try
            {
                con = new SqlConnection(
                            //"Data Source=RA52PCALU-31510;" +
                            //"Initial Catalog=" + bd + "; " +
                            //"User id=sa; " +
                            //"Password=123456;"
                            "Data Source=localhost;" +
                            "Initial Catalog=" + bd + "; " +
                            "User id=sa; " +
                            "Password=123456;"
                        );
            }
            catch (Exception)
            {
                con = new SqlConnection(
                "Data Source = localhost;" +
            "Initial Catalog = banco;" +
            "Integrated Security=SSPI;");
            }

            /*
            Autenticación de windows

            "Data Source=ServerName;" +
            "Initial Catalog=DataBaseName;" +
            "Integrated Security=SSPI;";
            */

            // url de conexión
        }

        public void Ejecutar(String query)
        {
            Console.WriteLine("QUERY=" + query);

            con.Open();
            sen = new SqlCommand(query, con);

            if (query.ToLower().Contains("select"))
            {
                rs = sen.ExecuteReader();
            }
            else
            { //insert, update, delete
                sen.ExecuteNonQuery();
                Cerrar();
            }
        }

        public void Cerrar()
        {
            con.Close();
        }
    }
}