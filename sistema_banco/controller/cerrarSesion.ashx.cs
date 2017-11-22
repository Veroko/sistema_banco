using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de cerrarSesion
    /// </summary>
    public class cerrarSesion:IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext context) {

            context.Session.Clear();

            context.Response.Redirect("../view/inicio.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}