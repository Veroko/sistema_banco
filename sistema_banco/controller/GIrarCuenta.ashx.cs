using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sistema_banco.model;

namespace sistema_banco.controller
{
    /// <summary>
    /// Descripción breve de GIrarCuenta
    /// </summary>
    public class GIrarCuenta : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                Data d = new Data();
                int monto = int.Parse(context.Request.Params["nmbGiro"]);
                int idCuenta = int.Parse(context.Request.Params["idCuenta2"]);
                int idUsu = int.Parse(context.Request.Params["idUsu2"]);
                int idTipoCuenta = int.Parse(context.Request.Params["idTipoCuenta2"]);

                
                List<Cuenta> lc = d.getCuenta(idCuenta);
                int resta = 0;
                foreach (Cuenta c in lc)
                {
                    if (c.TipoCuenta == idTipoCuenta)
                    {
                        resta = c.Saldo - monto;
                    }
                }
                d.ActualizarSaldo(resta, idUsu, idCuenta, idTipoCuenta);


            }
            catch (Exception)
            {

                context.Response.Write("Debe ingresar valores numéricos.");
            }
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}