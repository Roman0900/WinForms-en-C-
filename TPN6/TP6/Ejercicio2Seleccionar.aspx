<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2Seleccionar.aspx.cs" Inherits="Trabajo_Practico_N6.Ejercicio2Seleccionar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            text-align: center;
        }
        .auto-style2 {
            width: 300px;
            text-align: center;
        }
        .auto-style3 {
            width: 350px;
            text-align: center;
        }
        .auto-style4 {
            margin-left: 0px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="width:100%;text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;">
            Seleccionar Productos
        </h1>
        <div>
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">

                    </td>
                    <td class="auto-style2">
        <asp:GridView ID="gv_seleccionar" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" Width="600px" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gv_seleccionar_PageIndexChanging"  OnSelectedIndexChanging="gv_seleccionar_SelectedIndexChanging" PageSize="14" CssClass="auto-style4">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField></asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
         <div>
        <asp:Label ID="lbl_agregado" runat="server" Text="Producto agregado:"></asp:Label>
             <br />
        <asp:HyperLink ID="hl_inicio" runat="server" NavigateUrl="~/Ejercicio2_inicio.aspx">Volver al Inicio</asp:HyperLink>
    </div>
    </form>
   
</body>
</html>
