using sistema_banco.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de cambiarContraseña
    /// </summary>
    public class cambiarContraseña : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            Data d = new Data();

            /*obtener el id del usuario actual en la sesion ...*/
            

            Usuario u = new Usuario();
            
            int idUsuario = (int) context.Session[u.Id];

            u.Clave = context.Request.Params["txtNuevaContra"];

            d.updateContraseña(u.Clave,idUsuario);

            context.Response.Redirect("../view/Inicio.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}