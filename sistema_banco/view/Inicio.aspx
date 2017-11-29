<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="sistema_banco.view.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Bienvenido a Banco Estrella - Inicia sesión o registrate</title>
</head>
<body>
    <div>
        <form method="post" action="../controller/iniciarSesion.ashx">
            <h1>Banco Estrella</h1>
            
            <hr />
            <br />
            Ingrese su rut: 
            <input type="text" name="rut" placeholder="Ej:17125207-5" required="required" />
            <br />
            <br />
            Ingrese su clave: 
            <input type="password" name="txtPass" placeholder="Contraseña..." required="required" />
            <br />
            <br />
            <input type="submit" value="Iniciar sesión" />

        </form>

        <%--¿Cliente nuevo?, cambie su contraseña antes de iniciar sesión <a href="cambiarContraseña.aspx"><input type="button" value="Cambiar contraseña" /></a>--%>

        <%
            if (Request.Url.Equals(@"http://localhost:62667/view/inicio.aspx?m=0")) {
                Response.Write(
                    "<table>" +
                    "<tr>" +
                    "<td class='auto-style2'>¿No eres cliente?</td>" +
                    "<td class='auto-style2'>" +
                    "</tr>" +
                    "</table>"
                );
            }
            Response.Write("<a href='registrarUsuario.aspx'><input type='submit' value='Registrate!!' /></a >");
        %>
    </div>
</body>
</html>
