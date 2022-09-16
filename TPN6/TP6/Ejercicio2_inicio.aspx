<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2_inicio.aspx.cs" Inherits="Trabajo_Practico_N6.Ejercicio2_inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 2</title>
    <style type="text/css">
        .auto-style1 {
             text-align:center;
            width: 100%;
        }
        .auto-style2 {
           text-align:center;
            width: 217px;
        }
    </style>
</head>
<body>
    <h1 style="width:100%;text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;">
        Inicio Ejercicio 2

    </h1>
    <form id="form1" runat="server">
    <div>

        <table class="auto-style1">
            <tr>
                <td>
            <asp:HyperLink ID="hl_seleccion" runat="server" NavigateUrl="~/Ejercicio2Seleccionar.aspx">Seleccionar productos</asp:HyperLink>
                </td>
                <td class="auto-style2";>

            <asp:LinkButton ID="lb_eliminar" runat="server" OnClick="lb_eliminar_Click">Eliminar productos seleccionados</asp:LinkButton>
                </td>
                <td>

            <asp:HyperLink ID="hl_mostrar" runat="server" NavigateUrl="~/Ejercicio2ProdSeleccionados.aspx">Mostrat productos</asp:HyperLink>
                </td>
            </tr>
        </table>
        <div style="width:100%;text-align:center;">
            <br />

            <asp:HyperLink ID="returninicio" runat="server" NavigateUrl="~/Inicio.aspx">Volver Al inicio</asp:HyperLink>

        </div>
    </form>
</body>
</html>