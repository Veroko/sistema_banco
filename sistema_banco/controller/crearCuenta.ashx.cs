using sistema_banco.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de crearCuenta
    /// </summary>
    public class crearCuenta:IHttpHandler {

        public void ProcessRequest(HttpContext context) {

            Data d = new Data();

            Cuenta c = new Cuenta();



        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}