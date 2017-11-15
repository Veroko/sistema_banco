using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.model {
    public class Data {
        Conexion con;
        String query;


        public Data() {
            con = new Conexion("banco");
        }

        public void crearUsuario(Usuario us) {
            query = "INSERT INTO usuario VALUES('"+us.Rut+"','"+us.Nombre+"','"+us.Correo+"','"+us.Direccion+"','"+us.Fono+"','"+us.Tar_coordenadas+"','"+us.Clave+"','"+us.NumCuenta+"')";

            con.Ejecutar(query);
        }

        public void crearCuenta(Cuenta cue) {
            query = "INSERT INTO cuenta VALUES()";
        }
    }
}