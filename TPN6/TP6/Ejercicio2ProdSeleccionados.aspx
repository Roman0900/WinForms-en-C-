<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2ProdSeleccionados.aspx.cs" Inherits="Trabajo_Practico_N6.Ejercicio2ProdSeleccionados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos Seleccionados
    </title>
    <style type="text/css">
        .auto-style1 {
            text-align:center;
            width: 100%;
        }
        .auto-style2 {
            width: 700px;
        }
        .auto-style3 {
            width: 300px;
        }
      
        .auto-style4 {
            text-align: center;
            width: 61%;
        }
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2 style="width:100%;text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;" >
            Productos Seleccionados
        </h2>
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">

                    </td>
                    <td class="auto-style4">
            <asp:GridView ID="gv_mostrar" runat="server" CellPadding="4" ForeColor="#333333"  Width="600px" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
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
                    <td class="auto-style3">

                    </td>
                </tr>
            </table>

        </div>
        <div>
        </div>  
          <div>
        <asp:HyperLink ID="hl_inicio" runat="server" NavigateUrl="~/Ejercicio2_inicio.aspx">Volver al Inicio</asp:HyperLink>
      </div>
    </form>
    
</body>
</html>

