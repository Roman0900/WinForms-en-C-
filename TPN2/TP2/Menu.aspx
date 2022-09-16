<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Trabajo_Practico_N2.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 295px">
    <form id="form1" runat="server">
        <h2 style="width:100%;text-align:center;">

            Trabajo Practico Nº2</h2>
        <div style="width:100%;text-align:center; text-decoration: underline;">

            Integrantes del Grupo 10<br /><br />

        </div>
        <div style="width:100%;text-align:center; height: 83px;">
            <asp:ListBox ID="ListBox1" runat="server" style="margin-left: 0px" Width="297px" Height="89px">
                <asp:ListItem>Pablo Sebastián Castañeda</asp:ListItem>
                <asp:ListItem>Santiago Britos</asp:ListItem>
                <asp:ListItem>Carlos Gabriel Gómez</asp:ListItem>
                <asp:ListItem>Federico Román Pereyra</asp:ListItem>
                <asp:ListItem>Soraire Leandro</asp:ListItem>
            </asp:ListBox>
            
        </div>
        <div style="width:100%;text-align:center;">
            <br /><br />
            <asp:Button ID="ButtonEje1" runat="server" Text="Ejercicio 1" OnClick="ButtonEje1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonEje2" runat="server" Text="Ejercicio 2" OnClick="ButtonEje2_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonEje3" runat="server" Text="Ejercicio 3" OnClick="ButtonEje3_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonEje4" runat="server" Text="Ejercicio 4" OnClick="ButtonEje4_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonEje5" runat="server" Text="Ejercicio 5" OnClick="ButtonEje5_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
