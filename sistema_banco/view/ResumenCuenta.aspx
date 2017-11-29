<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResumenCuenta.aspx.cs" Inherits="sistema_banco.view.ResumenCuenta" %>
<%@ Import Namespace="sistema_banco.model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body>

       <%
           Usuario u = new Usuario();

           if(Session["usuario"] != null) {
               u = (Usuario) Session["usuario"];
           } else {
               Response.Redirect("");
           }
           /*Aquí entregarle el id(no rut) del usuario a getTarjeta*/

           Data d = new Data();
           List<Cuenta> lista = d.getCuenta(u.Id);

           d.crearCodigo(u.Id);

           TarjetaTransferencia t = d.getTarjeta(u.Id); /*<---- Arreglar ese detalle*/
           string[] codigo = t.Codigos.Split('|');
        %>
    <div class="auto-style1"> 
        <form action="../controller/cerrarSesion.ashx" method="post">
            <input type="submit" value="Cerrar Sesión" />
        </form>
    </div>
    <hr />
    <h2 class="auto-style2">Datos</h2>
    
    <%
        Response.Write("Usuario:"+u.Nombre);
        Response.Write("<br />");
        Response.Write("<br />");
        Response.Write("<hr />");
        
        int contCuentas = 0;
        foreach(Cuenta c in lista) {
            Response.Write("<ul>");
            contCuentas++;
            Response.Write("<br /><li>Cuenta N° "+contCuentas+"</li>");
            if(c.TipoCuenta == 1) {
                Response.Write("<br /><li>Tipo Cuenta: Cuenta Corriente</li>");
            }else if(c.TipoCuenta == 2){
                Response.Write("<br /><li>Tipo Cuenta: Cuenta Rut</li>");
            }else if(c.TipoCuenta == 3) {
                Response.Write("<br /><li>Tipo Cuenta: Cuenta de ahorro</li>");
            }
            Response.Write("<br /><li>ID de la cuenta/Numero de Cuenta: "+c.Id+"</li>");
            Response.Write("<br /><li>Saldo: "+c.Saldo+"</li>");
            Response.Write("<br /><li>Giro Maximo: "+c.GiroMaximo+"</li>");
            Response.Write("</ul>");
            %>
            <br /><h3>Depositar</h3>
    <form action="../controller/ActualizarSaldo.ashx" method="post">
        <input type="number" name="nmbDeposito" required="required"/>
        <%
            Response.Write("<input type='hidden' name='idCuenta' value="+c.Id+"></input>");
            Response.Write("<input type='hidden' name='idUsu' value="+u.Id+"></input>");
            Response.Write("<input type='hidden' name='idTipoCuenta' value="+c.TipoCuenta+"></input>");

        %>
        &nbsp;<input type="submit" name="btnDepositar" value="Depositar" /><br /><h3>Girar</h3>
    <form action="../controller/ActualizarSaldo.ashx" method="post">
        <input type="number" name="nmbGiro" required="required"/>
        <%
            Response.Write("<input type='hidden' name='idCuenta2' value="+c.Id+"></input>");
            Response.Write("<input type='hidden' name='idUsu2' value="+u.Id+"></input>");
            Response.Write("<input type='hidden' name='idTipoCuenta2' value="+c.TipoCuenta+"></input>");

        %>
        <input type="submit" name="btnGirar" value="Girar" />
        <br />
        <br />
        <hr />
    </form>

        <%}
    %>
    
    <h4>Tarjeta de transferencia</h4>
    <table border="1">
        <tr>
            <th ></th>
            <th >A</th>
            <th >B</th>
            <th >C</th>
            <th >D</th>
            <th >E</th>
            <th >F</th>
            <th >G</th>
            <th >H</th>
            <th >I</th>
            <th >J</th>
        </tr>
        <%
            int j = 0;
            int k = 1;
            int cont = 0;
            for (int i = 0; i<55; i++)
            {
                if (j == 0)
                {
                    Response.Output.Write("<tr>");
                    Response.Output.Write("<td class='naranjo'>" + k + "</td>");
                    k++;
                }
                else
                {
                    Response.Output.Write("<td class='texto'>"+codigo[cont]+"</td>");
                    cont++;
                }

                if (j == 10)
                {
                    Response.Output.Write("</tr>");
                    j = 0;
                }
                else
                {
                    j++;
                }

                
            }
        %>
    </table>
    <br />
    <a href="banco.aspx"><input type="submit" value="Ir a Home"/></a>
</body>
</html>
