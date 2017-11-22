<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="sistema_banco.view.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form method="post" action="../controller/iniciarSesion.ashx">
        <input type="text" name="rut"/>

        <br />

        <input type="password" name="txtPass" />


        <input type="submit" value="Iniciar sesión"/>


    </form>

    ¿No eres cliente?. <a href="registrarUsuario.aspx"><input type="submit" value="Registrate" /></a>
</body>
</html>
