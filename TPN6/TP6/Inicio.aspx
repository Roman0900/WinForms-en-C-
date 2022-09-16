<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Trabajo_Practico_N6.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            text-align:center;
        }
        .auto-style2 {
            width: 50%;
            text-align:left;
            height: 23px;
        }
        .auto-style5 {
            width: 42%;
            text-align: right;
            height: 23px;
        }
        .auto-style6 {
            width: 16%;
            text-align: center;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2 style="width:100%;text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;">
            Trabajo Practico Nº 6
            <br />
        </h2>
        <h3 style="width:100%;text-align:left; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;">
            Grupo Nº 10
        </h3>
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:HyperLink ID="Linkejer1" runat="server" NavigateUrl="Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="LinkEjer2" runat="server" NavigateUrl="~/Ejercicio2_inicio.aspx">Ejercicio 2</asp:HyperLink>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
