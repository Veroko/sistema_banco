<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="banco.aspx.cs" Inherits="sistema_banco.view.banco" %>
<%@ Import Namespace="sistema_banco.model" %>
<!DOCTYPE html>
 <%
     Usuario u = new Usuario();

     if(Session["usuario"] != null) {
         u = (Usuario) Session["usuario"];

     } else {
         Response.Redirect("registrarCuenta.aspx");
     }
     Data d = new Data();

   List<Cuenta> lista = d.getCuenta(u.Id);
%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
</head>
<body>
    <%-- En este aspx se muestra el nombre de usuario, saldos, y todo lo que quiera hacer el fulanito --%>
    <div> 
        <form action="../controller/cerrarSesion.ashx" method="post">
            <input type="submit" value="Cerrar Sesión" />
        </form>
    </div>
    <hr />
        <% 
            int contadorCuentas = lista.Count;
            Response.Write("<h4>ID: '"+u.Id+"'</h4>");
            Response.Write("<h4>Usuario: '"+u.Nombre+"'</h4>");
            
            Response.Write("<h4>N° de cuentas asociadas: '"+contadorCuentas+"'</h4>");
            Response.Write("<hr />");
            if (contadorCuentas > 0){
                Response.Write("<br /><a href='ResumenCuenta.aspx'><input type='submit' value='Resumen cuenta'/></a>");
                Response.Write("<a href='registrarCuenta.aspx'><input type='submit' value='Crear Cuenta'/></a></br /><br />");
            }
            else{
                Response.Write("<p>¿No tienes una cuenta?</p>");
                Response.Write("<a href='registrarCuenta.aspx'>Crear Cuenta</a>");

            }
        %>
        
</body>
</html>
