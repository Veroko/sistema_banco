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

            /*------------------------------------------------------------------------*/
            /*-------------------Aquí generamos clave automatica----------------------*/

                var charsMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var charsMin = "abcdefghijklmnopqrstuvwxyz";
                var charsNum = "0123456789";
                var charsSign = "#$%&+-*/_";

                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < 3; i++) {
                    stringChars[i] = charsMin[random.Next(charsMin.Length)];
                }

                for (int i = 3; i < 5; i++) {
                    stringChars[i] = charsNum[random.Next(charsNum.Length)];
                }

                for (int i = 5; i < 6; i++) {
                    stringChars[i] = charsMay[random.Next(charsMay.Length)];
                }

                for (int i = 6; i < 7; i++) {
                    stringChars[i] = charsSign[random.Next(charsSign.Length)];
                }
                var finalString = new String(stringChars);

            /*---------------------------------------------------------------*/

             us.Rut = context.Request.Params["txtRut"];
            us.Nombre = context.Request.Params["txtNombre"];
            us.Correo = context.Request.Params["txtCorreo"];
            us.Direccion = context.Request.Params["txtDireccion"];
            us.Fono = context.Request.Params["txtFono"];
            us.Clave = finalString;


            d.crearUsuario(us);

            context.Response.Redirect("../View/Inicio.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}