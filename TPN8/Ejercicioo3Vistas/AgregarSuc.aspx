<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSuc.aspx.cs" Inherits="Vistas.AgregarSuc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AGREGAR SUCURSALES</title>
   
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
            text-align:center;
        }
        .auto-style2 {
            width: 1500px;
            text-align:left;
        }
        .auto-style3 {
            width: 500px;
            text-align: right;
        }
       

        .auto-style4 {
            width: 370px;
        }
       

        .auto-style5 {
            margin-left: 160px;
        }
       

    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>

             <table class="auto-style1">
                 <tr>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td><asp:HyperLink ID="hpAgregar" runat="server" NavigateUrl="~/AgregarSuc.aspx">Agregar Sucursal</asp:HyperLink></td>
                     <td><asp:HyperLink ID="hpListado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado De Sucursales</asp:HyperLink></td>
                     <td><asp:HyperLink ID="hpEliminar" runat="server" NavigateUrl="~/FormularioSucursales.aspx">Eliminar Sucursal</asp:HyperLink></td>
                 </tr>
                 <tr>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
             </table>

        </div>
        <h2 style="text-align:center; text-decoration: underline; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;">
            GRUPO Nº10
        </h2>
        <div style="text-align:left; font-weight:bold; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: x-large;">
            <p class="auto-style5">
            Agregar Sucursal
            </p>
        </div>
        <br />
        <br />
        <div>

            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Nombre Sucursal:&nbsp;</td>
                    <td class="auto-style4">&nbsp;<asp:TextBox ID="txtNombreSuc" runat="server" Width="350px" ValidationGroup="group1" placeholder="Sucursal"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfNombre" runat="server" ControlToValidate="txtNombreSuc" ErrorMessage="Cargar Un Nombre" ValidationGroup="group1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Descripcion:&nbsp;</td>
                    <td class="auto-style4">&nbsp;<asp:TextBox ID="txtDesc" runat="server" Height="60px" Width="350px" ValidateRequestMode="Disabled" Wrap="False" ValidationGroup="group1" placeholder="Descripcion..."></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="reDescripcion" runat="server" ControlToValidate="txtDesc" ErrorMessage="Cargar una Descripcion" ValidationGroup="group1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Provincia:&nbsp;</td>
                    <td class="auto-style4">&nbsp;<asp:DropDownList ID="ddlProvincia" runat="server" Width="355px" ValidationGroup="group1">
                        </asp:DropDownList></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Direccion:&nbsp;</td>
                    <td class="auto-style4">&nbsp;<asp:TextBox ID="txtDireccion" runat="server" Width="350px" ValidationGroup="group1" placeholder="Direccion 123"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="reDire" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Cargar una Direccion" ValidationGroup="group1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
        </div>
        <div style="text-align:center;">
            <asp:Button ID="btnAceptar" runat="server" ValidationGroup="group1" Text="Aceptar"  Width="150px" OnClick="btnAceptar_Click" class="btn btn-outline-primary" ></asp:Button>

        </div>
        <br />
        <div style="font-weight:bold; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: large;" class="text-center">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="#33CC33"></asp:Label>
        </div>
        <br />
        <div class="text-center">

            <asp:ValidationSummary ID="Errores1" runat="server" ValidationGroup="group1" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
