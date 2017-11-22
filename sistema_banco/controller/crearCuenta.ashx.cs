using sistema_banco.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de crearCuenta
    /// </summary>
    public class crearCuenta:IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext context) {

            Data d = new Data();

            Cuenta c = new Cuenta();
            Usuario u = new Usuario();
            int idUsuario = (int)context.Session[u.Id];

            c.Saldo = 0;
            c.GiroMaximo = null;
            c.TipoCuenta = Int32.Parse(context.Request.Params.Get("valorCbox"));
            c.Usuario = idUsuario;

            d.crearCuenta(c);

            context.Response.Redirect("../view/banco.apsx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}