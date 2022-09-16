<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="Trabajo_Practico_N5.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 3</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 337px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style12 {
            height: 49px;
        }
        .auto-style13 {
            width: 100%;
            height: 30px;
        }
        .auto-style14 {
            width: 428px;
            height: 23px;
        }
        .auto-style17 {
            width: 342px;
        }
        .auto-style18 {
            width: 337px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /> <br />
        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td  style="text-align:left;" class="auto-style18">
                        <asp:HyperLink ID="hlAgregar" runat="server" NavigateUrl="https://localhost:44384/Ejercicio1.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td style="text-align:center;" class="auto-style17">
                        <asp:HyperLink ID="hlListar" runat="server" NavigateUrl="https://localhost:44384/Ejercicio2.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td style="text-align:right;" class="auto-style17">
                        <asp:HyperLink ID="hlEliminar" runat="server" NavigateUrl="https://localhost:44384/Ejercicio3.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12" style="font-size: x-large; font-weight: bold" colspan="3">
                        <h2 style="text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;" class="auto-style13"><strong> 
                            Eliminar sucursales
 </strong></h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td style="text-align:center;" colspan="3">Ingrese ID sucursal :&nbsp; <asp:TextBox ID="txtID" runat="server" Width="208px" ValidationGroup="group1"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td style="text-align:center;" colspan="3">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="125px" OnClick="btnEliminar_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align:center;" colspan="3">
                        <br />
                        <asp:Label ID="lblAviso" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div>

        </div>
    </form>
</body>
</html>
