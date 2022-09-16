<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_3.2.aspx.cs" Inherits="Trabajo_Practico_N4.Ejercicio_3__2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Temas</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 327px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="width:100%;text-align:center;">
            Listado de libros :</h1>

        
        <div style="width:100%;text-align:center;">
            <br />
            <asp:GridView ID="gvTemas" runat="server" CssClass="auto-style1" Width="668px" Height="88px">
            </asp:GridView>
        </div>
        <div  style="width:100%;text-align:center;">
            <br />
            <br />
            <asp:LinkButton ID="link2" runat="server" OnClick="link2_Click">CONSULTAR OTRO TEMA</asp:LinkButton>
        </div>
        
    </form>
</body>
</html>
