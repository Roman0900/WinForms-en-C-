<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="Trabajo_Practico_N5.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 2</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 618px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style2">
            <tr>
                <td style="text-align:left;" class="auto-style18">
        <asp:HyperLink ID="hl_agregar" runat="server" NavigateUrl="https://localhost:44384/Ejercicio1.aspx">Agregar sucursal</asp:HyperLink>
                </td>
                <td style="text-align:center;" class="auto-style18">
        <asp:HyperLink ID="hl_listar" runat="server" NavigateUrl="https://localhost:44384/Ejercicio2.aspx">Listado de sucursales</asp:HyperLink>
                </td>
                <td style="text-align:right;" class="auto-style18">
        <asp:HyperLink ID="hl_eliminar" runat="server" NavigateUrl="https://localhost:44384/Ejercicio3.aspx">Eliminar sucursal</asp:HyperLink>
                </td>
            </tr>
        </table>
    </div>
    <h2 style="width:100%;text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;">Listado de sucursales</h2>
        <div style="width:100%;text-align:center;">
          
        </div>
        <div style="width:100%;text-align:center;">
            <table class="auto-style2">
                <tr>
                    <td>&nbsp;</td>
                    <td>
            <asp:Label ID="lbl_busqueda" runat="server" Text="Busqueda ingrese ID sucursal:  "></asp:Label>

            <asp:TextBox ID="txt_sucursal" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;
            <asp:Button ID="bttn_filtar" runat="server" Text="Filtrar" OnClick="bttn_filtar_Click" Height="23px" />
                        &nbsp;&nbsp;
            <asp:Button ID="bttn_mostrar" runat="server" Text="Mostrar todos" OnClick="bttn_mostrar_Click" />
                        &nbsp;&nbsp;
                              
                        &nbsp;&nbsp;
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style4">
                              
            <asp:RegularExpressionValidator ID="rev_sucursal" runat="server" ControlToValidate="txt_sucursal" ErrorMessage="*Ingrese un número" ValidationExpression="[0-9]{1,}"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="rfv_sucursales" runat="server" ControlToValidate="txt_sucursal" ErrorMessage="*Valor requerido"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
          </div>
        <div>

            <table class="auto-style2">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">
        <asp:GridView ID="gv_sucursales" runat="server" Width="1020px" CssClass="auto-style1"></asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
