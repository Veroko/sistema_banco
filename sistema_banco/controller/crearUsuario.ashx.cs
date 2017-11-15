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
            us.Tar_coordenadas = Convert.ToInt32(context.Request.Params["tarCordes"]);
            us.Clave = context.Request.Params["txtClave"];

            d.crearUsuario(us);

            context.Response.Redirect("../view/");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}