using sistema_banco.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de IniciarSesion
    /// </summary>
    public class IniciarSesion : IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext context) {
            //Validar inicio de sesion, además se usa sessions
            Data d = new Data();
            
            String rut = context.Request.Params.Get("rut");
            String pass = context.Request.Params.Get("txtPass");
            Usuario u = d.getUsuario(rut);

            if(u != null) {
                
                context.Session["usuario"] = u;
                context.Response.Redirect("../view/banco.aspx");
            } else {
                
                context.Response.Redirect("../view/inicio.aspx?m=0");
            }
            
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}