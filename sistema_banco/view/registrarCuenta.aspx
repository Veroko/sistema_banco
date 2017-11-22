﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrarCuenta.aspx.cs" Inherits="sistema_banco.view.registrarCuenta" %>
<%@ Import Namespace="sistema_banco.model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <%-- en este aspx, una vez se incio sesion, se podra establecer que tipo de cuenta quiere agregar, cuenta rut, etc 
        debido a que la tabla cuenta posee otros atributos que no debe ingresar el usuario (como monto maximo, saldo) estos se deben poner a la "fuerza", solo al momento de crear una cuenta--%>
<body>
    <div> 
        <form action="../controller/cerrarSesion.ashx" method="post">
            <input type="submit" value="Cerrar Sesión" />
        </form>
    </div>
    <%
        Data d = new Data();
        
        List<TipoCuenta> lista = d.getTipoCuenta();

    %>
    <h2>Seleccione tipo de cuenta</h2>
    <br />
    <form action="../controller/registrarCuenta.aspx" method="post">

        <select name="cboxTipoCuenta" style="width: 204px">
            <%foreach(TipoCuenta t in lista) {
                    Response.Write("<option name='valorCbox' value='" + t.Id + "'>" + t.Cuenta + "</option>");
              }%>
            <option ></option>
        </select>

        <h6>Seleccione una de las opciones y podra agregar un tipo de cuenta para usted</h6>
        <input type="submit" value="Aceptar" />


    </form>
    <a href="banco.aspx"><input type="submit" value="Ir a Home"/></a>
</body>
</html>
