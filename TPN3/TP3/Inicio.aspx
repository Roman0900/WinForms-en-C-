<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Trabajo_Practico_N_3.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="width:100%;text-align:center;">
                Bienvenido a Inicio.aspx
            </h1>
        </div>
        <div style="width:100%;text-align:center;">
            <br />
            <asp:Button ID="UsuarioBack" runat="server" Text="Ir a Usuario" OnClick="UsuarioBack_Click" Width="148px" />

        </div>
    </form>
</body>
</html>
