<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Ejercicioo3Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LISTADO DE SUCURSALES</title>

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


        .auto-style21 {
            width: 746px;
        }
        .auto-style22 {
            width: 357px;
        }
        .auto-style23 {
            width: 407px;
        }
        .auto-style24 {
            text-align: right;
            width: 407px;
        }
        .auto-style25 {
            width: 352px;
        }
        .auto-style26 {
            width: 101px;
        }
        .auto-style27 {
            width: 699px;
        }
        .auto-style28 {
            width: 218px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
        <div>
        </div>
        <table class="w-100">
            <tr>
                <td class="text-end">
                        <asp:HyperLink ID="hlAgregar" runat="server" NavigateUrl="~/AgregarSuc.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                <td class="text-center">
                        <asp:HyperLink ID="hlListar" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                <td class="text-start">
                        <asp:HyperLink ID="hlEliminar" runat="server" NavigateUrl="~/FormularioSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style21">
                    <h1><strong>Listado de sucursales</h1>
&nbsp;</strong></td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="w-100">
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style25">

                    <asp:RequiredFieldValidator ID="rfv_sucursal" runat="server" ControlToValidate="txt_busqueda" ErrorMessage="*Valor obligatorio"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rev_sucursal" runat="server" ControlToValidate="txt_busqueda" ErrorMessage="*Ingrese sólo números" ValidationExpression="[0-9]{1,}"></asp:RegularExpressionValidator>

                </td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                     <asp:Label ID="lbl_busqueda" runat="server" Text="Busqueda ingrese ID sucursal"></asp:Label>
                  </td>
                <td class="auto-style25">&nbsp;&nbsp;
                    <asp:TextBox ID="txt_busqueda" runat="server" Width="320px" placeholder="Ingrese ID"></asp:TextBox>

                    </td>
                <td class="auto-style26">
                    <asp:Button ID="bttn_filtrar" runat="server" Text="Filtrar" OnClick="bttn_filtrar_Click" Width="89px" class="btn btn-primary" />

                </td>
                <td class="auto-style28">
                    <asp:Button ID="bttn_mostrar" runat="server" Text="Mostrar todos" OnClick="bttn_mostrar_Click" class="btn btn-primary" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style27">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style27">

        <asp:GridView ID="gv_sucursales" runat="server" class="table table-striped table-hover"></asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
