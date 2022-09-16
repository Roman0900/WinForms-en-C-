<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Trabajo_Practico_N5.Ejercicio11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style11 {
            width: 605px;
        }
        .auto-style12 {
            width: 189px;
        }
        .auto-style13 {
            height: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hplAgregarSucursal" runat="server" NavigateUrl="https://localhost:44384/Ejercicio1.aspx">Agregar Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hplListadoSucursales" runat="server" NavigateUrl="https://localhost:44384/Ejercicio2.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hplEliminarSucursal" runat="server" NavigateUrl="https://localhost:44384/Ejercicio3.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <h2 style="width:100%;text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;">
                
                GRUPO Nº 10
                <br />
                <br />
            </h2>
        </div>
        <div>

            <table class="auto-style1">
                <tr>
                    <td  style="text-align:right;" class="auto-style11">
                        Nombre sucursal:</td>
                    <td  style="text-align:center;" class="auto-style12">
                        <asp:TextBox ID="txtNombreSucursal" runat="server" ValidationGroup="group1"></asp:TextBox>
                        </td>
                    <td  style="text-align:left;" class="auto-style18">
                        <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ValidationGroup="group1">Ingrese Nombre Sucursal</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;" class="auto-style11">
                        Descripcion:</td>
                    <td  style="text-align:center;" class="auto-style12">
                        <asp:TextBox ID="txtDesripcion" runat="server" ValidationGroup="group1"></asp:TextBox>
                        </td>
                    <td  style="text-align:left;" class="auto-style18">
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDesripcion" ValidationGroup="group1">Ingrese Descripcion</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;" class="auto-style11">
                        Provincia:</td>
                    <td  style="text-align:center;" class="auto-style12">
                        <asp:DropDownList ID="ddlProvincia" runat="server" ValidationGroup="group1">
                            <asp:ListItem Value="0">--Seleccione Provincia--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align:right;" class="auto-style11">
                        Direccion:</td>
                    <td  style="text-align:center;" class="auto-style12">
                        
                        <asp:TextBox ID="txtDireccion" runat="server" ValidationGroup="group1"></asp:TextBox>
                        </td>
                    <td  style="text-align:left;" class="auto-style18">
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ValidationGroup="group1">Ingrese Direccion</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style12">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td style="text-align:center;" class="auto-style18">
                        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" ValidationGroup="group1" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="lblMensajeAgregado" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>

