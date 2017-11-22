<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResumenCuenta.aspx.cs" Inherits="sistema_banco.view.ResumenCuenta" %>
<%@ Import Namespace="sistema_banco.model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

       <%

           /*Aquí entregarle el rut del usuario a getTarjeta*/

           Data d = new Data();
           Usuario u = d.getUsuario("aquí entregarle el rut");
           
           TarjetaTransferencia t = d.getTarjeta(u.id); /*<---- Arreglar ese detalle*/
           string[] codigo = t.Codigos.Split('|');
        %>

    <h2>Datos</h2>

    <%
       /*mostrar datos de usuario y el tipo de cuenta*/ 
    %>

    <h4>Tarjeta de transferencia</h4>
    <table >
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
</body>
</html>
