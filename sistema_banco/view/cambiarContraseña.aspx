<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cambiarContraseña.aspx.cs" Inherits="sistema_banco.view.cambiarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form method="post" action="../controller/cambiarContraseña.ashx">
        <div>
           <p>Porqué nos preocupamos de su seguridad le pedimos que cambie su contraseña 
            </p> 

           

            <input type="password" name="txtNuevaContra" />

            <input type="submit" value="Cambiar"/>
        </div>
    </form>
</body>
</html>
