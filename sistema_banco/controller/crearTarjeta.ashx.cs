using sistema_banco.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace sistema_banco.controller {
    /// <summary>
    /// Descripción breve de crearTarjeta
    /// </summary>
    public class crearTarjeta : IHttpHandler, IRequiresSessionState {

        public void ProcessRequest(HttpContext context) {
                Data d = new Data();
                Random randomCodigo;
                string codigos;

            TarjetaTransferencia t = new TarjetaTransferencia();
            Usuario u = new Usuario();


        codigos = "";
            randomCodigo = new Random();
            for (int i = 0; i < 50; i++) {
                string agregar = "";
                int numero = randomCodigo.Next(0, 100);
                if (numero < 10) {
                    agregar = "0" + numero;
                } else {
                    agregar = numero.ToString();
                }
                if (i == 0) {
                    codigos += agregar;
                } else {
                    codigos += "|" + agregar;
                }
            }

            t.Codigos = codigos;
            t.User = u.Id;

            d.crearTajeta(t);

        }

       

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}