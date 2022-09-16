<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mostrarSucursalesSeleccionadas.aspx.cs" Inherits="TP7_PROG3_2021_1C.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 359px;
        }
        .auto-style3 {
            width: 338px;
        }
        .auto-style4 {
            text-align: center;
            font-size: large;
        }
        .auto-style5 {
            width: 387px;
        }
        .auto-style6 {
            width: 453px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hlkListadoSucursales" runat="server" NavigateUrl="~/listadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlkMorstrarSucursalesSeleccionadas" runat="server" NavigateUrl="~/mostrarSucursalesSeleccionadas.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="3">
                        <h1><strong>Mostrar Sucursales Seleccionadas</strong></h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:GridView ID="grdSucursalesSeleccionadas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
        <div>
            <asp:Label ID="lblIntegrantes" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
