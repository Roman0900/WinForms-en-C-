<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Trabajo_Practico_N4.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        MENU
    </title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="width:100%;text-align:center; text-decoration: underline;">
                Trabajo Practico N4
            </h1>
        </div>
        <div style="width:100%;text-align:center;">

            <div style="width:100%;text-align:center; text-decoration: underline;">
                Integrantes del Grupo 10<br />
                <br />
            </div>
            <div style="width:100%;text-align:center; height: 83px;">
                <asp:ListBox ID="ListBox1" runat="server" Height="108px" style="margin-left: 0px" Width="297px">
                    <asp:ListItem>Pablo Sebastián Castañeda</asp:ListItem>
                    <asp:ListItem>Santiago Britos</asp:ListItem>
                    <asp:ListItem>Carlos Gabriel Gómez</asp:ListItem>
                    <asp:ListItem>Federico Román Pereyra</asp:ListItem>
                    <asp:ListItem>Soraire Leandro</asp:ListItem>
                </asp:ListBox>
            </div>
            <div style="width:100%;text-align:center;">
                <br />
                <br />
                <br />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonEje1" runat="server" Text="Ejercicio 1" class="btn btn-primary dropdown-toggle" OnClick="ButtonEje1_Click1"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonEje2" runat="server" Text="Ejercicio 2" class="btn btn-primary dropdown-toggle" OnClick="ButtonEje2_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ButtonEje3" runat="server" Text="Ejercicio 3" class="btn btn-primary dropdown-toggle" OnClick="ButtonEje3_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>

        </div>
    </form>
</body>
</html>
