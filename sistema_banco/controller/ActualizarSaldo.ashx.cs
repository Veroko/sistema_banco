using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sistema_banco.model;

namespace sistema_banco.controller
{
    /// <summary>
    /// Descripción breve de ActualizarSaldo
    /// </summary>
    public class ActualizarSaldo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            
            try
            {

                Data d = new Data();
                
                int saldo = int.Parse(context.Request.Params["nmbDeposito"]);
                int idCuenta = int.Parse(context.Request.Params["idCuenta"]);
                int idUsu = int.Parse(context.Request.Params["idUsu"]);
                int idTipoCuenta = int.Parse(context.Request.Params["idTipoCuenta"]);
                List<Cuenta> lc = d.getCuenta(idCuenta);
                int resta = 0;
                foreach (Cuenta c in lc)
                {
                    if (c.TipoCuenta == idTipoCuenta)
                    {
                        resta = c.Saldo + saldo;
                    }
                }
                d.ActualizarSaldo(resta, idUsu, idCuenta, idTipoCuenta);

            }
            catch (Exception)
            {

                context.Response.Write("|....Debe ingresar valores numéricos....|");
            }
            context.Response.Redirect("../view/ResumenCuenta.aspx");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}