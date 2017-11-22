<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="banco.aspx.cs" Inherits="sistema_banco.view.banco" %>

<!DOCTYPE html>

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
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
