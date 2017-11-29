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


            int idUsuario = int.Parse(context.Request.Params.Get("id"));

            c.Usuario = idUsuario;
            c.Saldo = 0;
            c.GiroMaximo = "";
            c.TipoCuenta = Int32.Parse(context.Request.Params.Get("cboxTipoCuenta"));
           
            

            d.crearCuenta(c);

            context.Response.Redirect("../view/banco.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}