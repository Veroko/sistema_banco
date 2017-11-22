using sistema_banco.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de IniciarSesion
    /// </summary>
    public class IniciarSesion : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            //Validar inicio de sesion, además se usa sessions
            Data d = new Data();
            String rut = context.Request.Params.Get("rut");
            String pass = context.Request.Params.Get("txtPass");

            if(rut ==  d.getUsuario(rut, pass).Rut && pass == d.getUsuario(rut, pass).Clave) {
                context.Session.Clear();
                context.Session["usuario"] = d.getUsuario(rut);
                context.Response.Redirect("../view/banco.aspx");
            } else {
                context.Session.Clear();
                context.Response.Redirect("../view/inicio.aspx");
            }
            
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}