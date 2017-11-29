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
    <title></title>
</head>
<body>
    <%-- En este aspx se muestra el nombre de usuario, saldos, y todo lo que quiera hacer el fulanito --%>
    <div> 
        <form action="../controller/cerrarSesion.ashx" method="post">
            <input type="submit" value="Cerrar Sesión" />
        </form>
    </div>
        <% 
            int contadorCuentas = lista.Count;
            Response.Write("<h5>ID: '"+u.Id+"'</h5></br>");
            Response.Write("<h5>Usuario: '"+u.Nombre+"'</h5></br>");
            
            Response.Write("<h5>N° de cuentas asociadas: '"+contadorCuentas+"'</h5><br>");
            if (contadorCuentas > 0){
                Response.Write("</br></br><a href='ResumenCuenta.aspx'><input type='submit' value='Resumen cuenta'/></a>");
                Response.Write("<a href='registrarCuenta.aspx'><input type='submit' value='Crear Cuenta'/></a>");
            }
            else{
                Response.Write("</br /><br /><p>¿No tienes una cuenta?</p>");
                Response.Write("<a href='registrarCuenta.aspx'>Crear Cuenta</a>");

            }
        %>
        
</body>
</html>
