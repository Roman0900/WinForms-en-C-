<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioSucursales.aspx.cs" Inherits="Ejercicioo3Vistas.FormularioSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ELIMINAR SUCURSALES</title>

    <link rel="apple-touch-icon" sizes="57x57" href="Image/apple-icon-57x57.png"/>
<link rel="apple-touch-icon" sizes="60x60" href="Image/apple-icon-60x60.png"/>
<link rel="apple-touch-icon" sizes="72x72" href="Image/apple-icon-72x72.png"/>
<link rel="apple-touch-icon" sizes="76x76" href="Image/apple-icon-76x76.png"/>
<link rel="apple-touch-icon" sizes="114x114" href="Image/apple-icon-114x114.png"/>
<link rel="apple-touch-icon" sizes="120x120" href="Image/apple-icon-120x120.png"/>
<link rel="apple-touch-icon" sizes="144x144" href="Image/apple-icon-144x144.png"/>
<link rel="apple-touch-icon" sizes="152x152" href="Image/apple-icon-152x152.png"/>
<link rel="apple-touch-icon" sizes="180x180" href="Image/apple-icon-180x180.png"/>
<link rel="icon" type="image/png" sizes="192x192"  href="Image/android-icon-192x192.png"/>
<link rel="icon" type="image/png" sizes="32x32" href="Image/favicon-32x32.png"/>
<link rel="icon" type="image/png" sizes="96x96" href="Image/favicon-96x96.png"/>
<link rel="icon" type="image/png" sizes="16x16" href="Image/favicon-16x16.png"/>

     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" />

    <style type="text/css">


        .auto-style1 {
            width: 100%;
        }
        .auto-style18 {
            width: 337px;
            text-align: right;
        }
        .auto-style17 {
            width: 342px;
            text-align: center;
        }
        .auto-style12 {
            height: 49px;
        }
        .auto-style13 {
            width: 100%;
            height: 30px;
        }
        .auto-style4 {
            width: 337px;
            height: 23px;
        }
        .auto-style14 {
            width: 428px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style19 {
            width: 342px;
            text-align: left;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <br />
            <br />
        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style18">
                        <asp:HyperLink ID="hlAgregar" runat="server" NavigateUrl="~/AgregarSuc.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style17">
                        <asp:HyperLink ID="hlListar" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style19">
                        <asp:HyperLink ID="hlEliminar" runat="server" NavigateUrl="~/FormularioSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style19">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="3" style="font-size: x-large; font-weight: bold">
                        <h2 class="auto-style13" style="text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;"><strong>Eliminar sucursales </strong></h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align:center;">Ingrese ID sucursal :&nbsp;
                        <asp:TextBox ID="txtID" runat="server" ValidationGroup="group1" Width="208px" placeholder="Ingrese ID"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvIdSucursal" runat="server" ControlToValidate="txtID" ForeColor="Red">*Ingrese ID</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvIdSucursal" runat="server" ControlToValidate="txtID" ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="0">*Id Invalido</asp:CompareValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align:center;">
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Width="125px" class="btn btn-primary" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align:center;">
                        <br />
                        <asp:Label ID="lblAviso" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div>
        </div>
    </form>
  
        <div>
        </div>
    </form>
 
        <div>
        </div>
    </form>
</body>
</html>
