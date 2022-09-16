<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_1.aspx.cs" Inherits="Trabajo_Practico_N2.Ejercicio_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="width:100%;text-align:center;">&nbsp;<br />
            &nbsp;<br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp; Ingrese nombre del producto :
            <asp:TextBox ID="txtProducto1" runat="server" Width="150px"></asp:TextBox>
            &nbsp; Cantidad :
            <asp:TextBox ID="txtCantidad1" runat="server" Width="120px"></asp:TextBox>
            <br />
            <br />
            &nbsp; Ingrese nombre del producto :
            <asp:TextBox ID="txtProducto2" runat="server" Width="150px"></asp:TextBox>
            &nbsp;&nbsp;Cantidad :
            <asp:TextBox ID="txtCantidad2" runat="server" Width="120px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="return" runat="server" OnClick="return_Click" Text="Volver al Menu Principal" Width="170px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnTabla" runat="server" OnClick="btnTabla_Click" Text="Generar tabla" Width="150px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTabla" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
