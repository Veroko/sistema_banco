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
            context.Response.ContentType = "texto/normal";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}