using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace sistema_banco.model
{
    public class Data
    {
        Conexion con;
        String query;


        public Data()
        {
            con = new Conexion("banco");
        }

        public void crearUsuario(Usuario us)
        {

            query = $"INSERT INTO usuario VALUES('{us.Rut}','{us.Nombre}','{us.Correo}','{us.Direccion}','{us.Fono}', '{us.Clave}')";

            con.Ejecutar(query);
            con.Cerrar();
        }

        public List<TipoCuenta> getTipoCuenta()
        {
            List<TipoCuenta> lista = new List<TipoCuenta>();

            query = "SELECT * FROM tipoCuenta";
            TipoCuenta tc;
            con.Ejecutar(query);

            while (con.rs.Read())
            {
                tc = new TipoCuenta
                {
                    Id = con.rs.GetInt32(0),
                    Cuenta = con.rs.GetString(1)
                };
                lista.Add(tc);
            }

            con.Cerrar();
            return lista;
        }
        public Usuario getUsuario(String rut, String pass)
        {
            Usuario u = null;
            query = "SELECT * FROM usuario WHERE rut = '" + rut + "' AND clave ='" + pass + "'";
            con.Ejecutar(query);
            if (con.rs.Read())
            {
                u = new Usuario
                {
                    Id = con.rs.GetInt32(0),
                    Rut = con.rs.GetString(1),
                    Nombre = con.rs.GetString(2),
                    Correo = con.rs.GetString(3),
                    Direccion = con.rs.GetString(4),
                    Fono = con.rs.GetString(5),
                    Clave = con.rs.GetString(7)
                };
            }
            con.Cerrar();
            return u;
        }

        public Usuario getUsuario(String rut)
        {
            Usuario u = null;
            query = "SELECT * FROM usuario WHERE rut = '" + rut + "';";
            con.Ejecutar(query);
            if (con.rs.Read())
            {
                u = new Usuario
                {
                    Id = con.rs.GetInt32(0),
                    Rut = con.rs.GetString(1),
                    Nombre = con.rs.GetString(2),
                    Correo = con.rs.GetString(3),
                    Direccion = con.rs.GetString(4),
                    Fono = con.rs.GetString(5),
                    Clave = con.rs.GetString(6)
                };
            }
            con.Cerrar();
            return u;
        }

        public List<Usuario> getUsuarioList(String rut)
        {
            List<Usuario> lista = new List<Usuario>();
            Usuario u;
            query = "SELECT * FROM usuario WHERE rut = '" + rut + "';";
            con.Ejecutar(query);
            if (con.rs.Read())
            {
                u = new Usuario
                {
                    Id = con.rs.GetInt32(0),
                    Rut = con.rs.GetString(1),
                    Nombre = con.rs.GetString(2),
                    Correo = con.rs.GetString(3),
                    Direccion = con.rs.GetString(4),
                    Fono = con.rs.GetString(5),
                    Clave = con.rs.GetString(7)
                };
                lista.Add(u);
            }
            con.Cerrar();
            return lista;
        }

        public void crearCuenta(Cuenta cue)
        {
            switch (cue.TipoCuenta)
            {
                case 1:
                    query = "INSERT INTO cuenta VALUES('" + cue.Usuario + "', '" + cue.TipoCuenta + "' , 0, 'Sin Limite')";//cuando sea 0, se hará un if, si es null sera ilimitado
                    con.Ejecutar(query);
                    break;
                case 2:
                    query = "INSERT INTO cuenta VALUES('" + cue.Usuario + "', '" + cue.TipoCuenta + "' , 0, '200000')";
                    con.Ejecutar(query);
                    break;
                case 3:
                    query = "INSERT INTO cuenta VALUES('" + cue.Usuario + "', '" + cue.TipoCuenta + "' , 0, '15000000')";
                    con.Ejecutar(query);
                    break;
            }
        }

        public List<Cuenta> getCuenta(int id)
        {
            List<Cuenta> lista = new List<Cuenta>();
            query = "SELECT * FROM cuenta WHERE usuario = " + id;
            con.Ejecutar(query);
            Cuenta c;
            while (con.rs.Read())
            {
                c = new Cuenta
                {
                    Id = con.rs.GetInt32(0),
                    Usuario = con.rs.GetInt32(1),
                    TipoCuenta = con.rs.GetInt32(2),
                    Saldo = con.rs.GetInt32(3),
                    GiroMaximo = con.rs.GetString(4)
                };
                lista.Add(c);
            }
            con.Cerrar();
            return lista;
        }

        public void crearCodigo(int id)
        {
            Random randomCodigo;
            string codigos;

            TarjetaTransferencia t = new TarjetaTransferencia();



            codigos = "";
            randomCodigo = new Random();
            for (int i = 0; i < 50; i++)
            {
                string agregar = "";
                int numero = randomCodigo.Next(0, 100);
                if (numero < 10)
                {
                    agregar = "0" + numero;
                }
                else
                {
                    agregar = numero.ToString();
                }
                if (i == 0)
                {
                    codigos += agregar;
                }
                else
                {
                    codigos += "|" + agregar;
                }
            }

            t.Codigos = codigos;
            t.User = id;

            crearTajeta(t);

        }


        public TarjetaTransferencia getTarjeta(int num)
        {
            TarjetaTransferencia t = null;

            query = "SELECT * FROM tarjetaTransferencia WHERE user_fk = " + num;
            con.Ejecutar(query);

            if (con.rs.Read())
            {
                t = new TarjetaTransferencia();

                t.Id = con.rs.GetInt32(0);
                t.Codigos = con.rs.GetString(1);
                t.User = con.rs.GetInt32(2);
            }
            con.Cerrar();

            return t;
        }


        public void updateContraseña(string nueva, int id)
        {
            query = "UPDATE usuario SET clave = '" + nueva + "', primer_inicio = '0' WHERE id = '" + id + "'";
            con.Ejecutar(query);
            con.Cerrar();
        }

        public void crearTajeta(TarjetaTransferencia t)
        {
            query = "INSERT INTO tarjetaTransferencia VALUES('" + t.Codigos + "', '" + t.User + "')";
            con.Ejecutar(query);
            con.Cerrar();
        }

        public void ActualizarSaldo(int monto, int id, int idCuenta, int idTipoCuenta)
        {
            query = "UPDATE cuenta SET saldo = " + monto + " WHERE usuario = " + id + " AND tipoCuenta = " + idTipoCuenta + " AND id = " + idCuenta + "";
            con.Ejecutar(query);
            con.Cerrar();
        }
    }
}