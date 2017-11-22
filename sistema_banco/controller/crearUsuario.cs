using sistema_banco.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de crearUsuario
    /// </summary>
    public class crearUsuario : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            Data d = new Data();

            Usuario us = new Usuario();

            us.Rut = context.Request.Params["txtRut"];
            us.Nombre = context.Request.Params["txtNombre"];
            us.Correo = context.Request.Params["txtCorreo"];
            us.Direccion = context.Request.Params["txtDireccion"];
            us.Fono = context.Request.Params["txtFono"];
            us.Clave = context.Request.Params["txtClave"];

            if(us.Rut == d.getUsuario(us.Rut).Rut) {
                d.crearUsuario(us);
                context.Response.Redirect("../view/registrarUsuario.aspx");
            } else {
                context.Response.Redirect("../view/Error.aspx");
            }
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}