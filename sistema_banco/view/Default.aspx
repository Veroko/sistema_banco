<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sistema_banco.view.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="../controller/crearUsuario.ashx" method="post">
        
        <input type="text" name="txtRut" placeholder="19590104-k"/>

        <input type="text" name="txtNombre" placeholder="Juanito Perez" />

        <input type="text" name="txtCorreo" placeholder="alguien@gmail.com" />

        <input type="text" name="txtDireccion" placeholder="calle falsa 123" />

        <input type="text" name="txtFono" placeholder="+569 75487414" />

        <input type="number" name="tarCordes" />

        <input type="text" name="txtClave" />

        <input type="submit" value="OK" />
    </form>
</body>
</html>
