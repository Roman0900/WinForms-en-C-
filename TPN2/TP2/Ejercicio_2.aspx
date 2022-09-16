<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_2.aspx.cs" Inherits="Trabajo_Practico_N2.Ejercicio_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_nombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="TextBox_nombre" runat="server" Width="178px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_apellido" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="TextBox_apellido" runat="server" Width="174px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label_ciudad" runat="server" Text="Ciudad:"></asp:Label>
            <asp:DropDownList ID="DropDownList_ciudad" runat="server">
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label_temas" runat="server" Text="Temas:"></asp:Label>
        </div>
        <asp:CheckBoxList ID="CheckBoxList_materias" runat="server">
        </asp:CheckBoxList>
        <asp:Button ID="Button_resumen" runat="server" OnClick="Button_resumen_Click" Text="Ver Resumen" Width="109px" />
        <div>
            <asp:Label ID="Label_message" runat="server"></asp:Label>
        </div>
<div style="width:100%;text-align:center;">
    <br /><br />
    <asp:Button ID="returnbtn" runat="server" Text="Volver al Menu Principal" OnClick="returnbtn_Click" />

        </div>
    </form>
</body>
</html>
