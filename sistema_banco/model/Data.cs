using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace sistema_banco.model {
    public class Data {
        Conexion con;
        String query;
        

        public Data() {
            con = new Conexion("banco");
        }

        public void crearUsuario(Usuario us) {
            query = "INSERT INTO usuario VALUES('"+us.Rut+"','"+us.Nombre+"','"+us.Correo+"','"+us.Direccion+"','"+us.Fono+"','"+us.Clave+"')";

            con.Ejecutar(query);
            con.Cerrar();
        }

        public List<TipoCuenta> getTipoCuenta() {
            List<TipoCuenta> lista = new List<TipoCuenta>();

            query = "SELECT * FROM tipoCuenta";
            TipoCuenta tc;
            con.Ejecutar(query);

            while(con.rs.Read()) {
                tc = new TipoCuenta();

                tc.Id = con.rs.GetInt32(0);
                tc.Cuenta = con.rs.GetString(1);
                lista.Add(tc);
            }

            con.Cerrar();
            return lista;
        }
        public Usuario getUsuario(String rut, String pass) {
            Usuario u = null;
            query = "SELECT * FROM usuario WHERE rut = '"+rut+"' AND pass ='"+pass+"'";
            con.Ejecutar(query);
            if(con.rs.Read()) {
                u = new Usuario();

                u.Id = con.rs.GetInt32(0);
                u.Rut = con.rs.GetString(1);
                u.Nombre = con.rs.GetString(2);
                u.Correo = con.rs.GetString(3);
                u.Direccion = con.rs.GetString(4);
                u.Fono = con.rs.GetString(5);
                u.Clave = con.rs.GetString(7);
            }
            con.Cerrar();
            return u;
        }

        public Usuario getUsuario(String rut) {
            Usuario u = null;
            query = "SELECT * FROM usuario WHERE rut = '" + rut;
            con.Ejecutar(query);
            if(con.rs.Read()) {
                u = new Usuario();

                u.Id = con.rs.GetInt32(0);
                u.Rut = con.rs.GetString(1);
                u.Nombre = con.rs.GetString(2);
                u.Correo = con.rs.GetString(3);
                u.Direccion = con.rs.GetString(4);
                u.Fono = con.rs.GetString(5);
                u.Clave = con.rs.GetString(7);
            }
            con.Cerrar();
            return u;
        }
        public void crearCuenta(Cuenta cue) {
            switch(cue.TipoCuenta) {
                case 1:
                query = "INSERT INTO cuenta VALUES('" + cue.Usuario + "', '" + cue.TipoCuenta + "' , 0, 200000)";
                break;
                case 2:
                query = "INSERT INTO cuenta VALUES('" + cue.Usuario + "', '" + cue.TipoCuenta + "' , 0, null)";//cuando sea null, se hará un if, si es null sera ilimitado
                break;
                case 3:
                query = "INSERT INTO cuenta VALUES('" + cue.Usuario + "', '" + cue.TipoCuenta + "' , 0, 15000000)";
                break;
            }

            con.Ejecutar(query);
            con.Cerrar();
            
        }
    }
}