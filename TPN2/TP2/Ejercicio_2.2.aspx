<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_2.2.aspx.cs" Inherits="Trabajo_Practico_N2.Ejercicio_2__2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h2>Resumen</h2>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label_nombre" runat="server" Text="Nombre:"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label_apellido" runat="server" Text="Apellido:"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label_zona" runat="server" Text="Zona:"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label_temas" runat="server" Text="Los temas elegidos son:"></asp:Label>
        </div>
        <div style="width:100%;text-align:center;">
    <br /><br /><br /><br /><br />
    <asp:Button ID="returnbtn" runat="server" Text="Volver al Menu Principal" OnClick="returnbtn_Click" />

        </div>
    </form>
</body>
</html>
