<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrarUsuario.aspx.cs" Inherits="sistema_banco.view.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Banco Estrella - Registro</title>
</head>
<body>

    <h1>Registro</h1>
    <hr />
    <br />
    <form action="../controller/crearUsuario.ashx" method="post">
        Ingrese su rut: 
        <input type="text" name="txtRut" placeholder="19590104-k" required="required"/>
        <br />
        <br />
        Ingrese su nombre: 
        <input type="text" name="txtNombre" placeholder="Juanito Perez" required="required"/>
        <br />
        <br />
        Ingrese su dirección de correo electrónico: 
        <input type="text" name="txtCorreo" placeholder="alguien@gmail.com" required="required"/>
        <br />
        <br />
        Ingrese su dirección de domicilio: 
        <input type="text" name="txtDireccion" placeholder="calle falsa 123" required="required"/>
        <br />
        <br />
        Ingrese su número de contacto: 
        <input type="text" name="txtFono" placeholder="+569 75487414" required="required"/>
        <br />
        <br />
        Ingrese su contraseña: 
        <input type="password" name="txtPass" required="required" />
        <br />
        <br />
        <input type="submit" value="OK" />
    </form>

        <a href="Inicio.aspx"><input type="submit" value="Volver" /> </a>
</body>
</html>
