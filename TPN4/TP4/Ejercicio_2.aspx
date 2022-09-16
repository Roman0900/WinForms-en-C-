<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_2.aspx.cs" Inherits="Trabajo_Practico_N4.Ejercicio_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:100%;text-align:center;">
            <asp:Label ID="lbl_producto" runat="server" Text="Id Producto:"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="dll_producto" runat="server"></asp:DropDownList>
            <asp:TextBox ID="txt_producto" runat="server" ></asp:TextBox>
            <asp:RegularExpressionValidator ID="rev_pro" runat="server" ControlToValidate="txt_producto" ErrorMessage="*Ingrese un número" ValidationExpression="[0-9]{1,}"></asp:RegularExpressionValidator>
        </div>
        <div style="width:100%;text-align:center;">
                <asp:Label ID="lbl_categoria" runat="server" Text="IdCategoria:"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="dll_categoria" runat="server"></asp:DropDownList>
            <asp:TextBox ID="txt_categoria" runat="server"></asp:TextBox>

                <asp:RegularExpressionValidator ID="rev_cat" runat="server" ControlToValidate="txt_categoria" ErrorMessage="*Ingrese un número" ValidationExpression="[0-9]{1,}"></asp:RegularExpressionValidator>

        </div>
        <div style="width:100%;text-align:center;">
            <br />
            <asp:Button ID="bttn_filtrar" runat="server" Text="Filtrar" OnClick="bttn_filtrar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bttn_quitarfiltro" runat="server" Text="Quitar Filtro" OnClick="bttn_quitarfiltro_Click" />
            <br /><br />
        </div>
       
        <div style="width:100%;text-align:center;">
        <asp:GridView ID="gv_neptuno" runat="server" Width="891px"></asp:GridView>
        </div>
       
        <div style="width:100%;text-align:center;">
            <br /><br />
            <asp:Button ID="Backtomenu" runat="server" Text="Volver al Menu" OnClick="Backtomenu_Click" />
        </div>
    </form>
</body>
</html>