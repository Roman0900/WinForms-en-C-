<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Trabajo_Practico_N_3.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 79px;
        }
        .auto-style6 {
            width: 831px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="width:100%;text-align:center;">
                Trabajo Practico N3     
            <br />
        </h1>
       <h2 style="width:100%;text-align:center;">
           Localidades
           <br />
       </h2>
        <div >

            <table align="center" class="auto-style1">
                <tr>
                    <td align="right";class="auto-style3" class="auto-style6">
                       
                        <asp:Label ID="lblLocalidad" runat="server" Text="Nombre de la Localidad" Width="170px"></asp:Label>
                      
                        <asp:TextBox ID="txtLocalidad" runat="server" ValidationGroup="grupo1" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="txtLocalidad" ValidationGroup="grupo1" ErrorMessage="Ingrese una localidad">*</asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="revLocalidad" runat="server" ControlToValidate="txtLocalidad" ValidationExpression="^[a-zA-Z0-9]*$" ValidationGroup="grupo1" ErrorMessage="Ingrese solo nuemeros y letras">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>
        <div style="width:100%;text-align:center;">
            <asp:Button ID="btnSaveLocalidad" runat="server" Text="Guardar Localidad" ValidationGroup="grupo1" Width="142px" OnClick="btnSaveLocalidad_Click" />
            <br />

        </div>
        <h2 style="width:100%;text-align:center;">
            <br />
            Usuarios
        </h2>
            <div>

                <table align="center"; class="auto-style1">
                    <tr>
                        <td align="center";class="auto-style6">
                            
                            <asp:Label ID="lblUsuario" runat="server" Text="Nombre de Usuario" Width="150px"></asp:Label>
                            <asp:TextBox ID="txtUsuario" runat="server" Width="180px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ErrorMessage="Ingresar Nombre de Usuario" ControlToValidate="txtUsuario" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="center";class="auto-style6">
                            <asp:Label ID="lblPassword" runat="server" Width="150px" Text="Contraseña"></asp:Label>
                            <asp:TextBox ID="txtContraseña" runat="server" Width="180px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ErrorMessage="Ingrese Contraseña" ControlToValidate="txtContraseña" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="center";class="auto-style6">
                            <asp:Label ID="lblRepetirPassword" runat="server" Width="150px" Text="Repetir Contraseña"></asp:Label>
                            <asp:TextBox ID="txtContraseñaRepeat" runat="server" Width="180px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CompareValidator ID="cvContraseña" runat="server" ErrorMessage="Las Contraseñas no son Iguales" ControlToCompare="txtContraseña" ControlToValidate="txtContraseñaRepeat" ValidationGroup="grupo2">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="center";class="auto-style6">
                            <asp:Label ID="lblMail" runat="server" Width="150px" Text="Correo Electronico"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" Width="180px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Ingresar un Email" ControlToValidate="txtEmail" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Formato de Email Invalido" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="grupo2">*</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="center";class="auto-style6">
                            <asp:Label ID="lblCP" runat="server" Width="150px" Text="Codigo Postal"></asp:Label>
                            <asp:TextBox ID="txtCp" runat="server" Width="180px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvCP" runat="server" ErrorMessage="Ingrese un Codigo Postal" ControlToValidate="txtCp" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="cusvaliCP" runat="server" ControlToValidate="txtCp" ErrorMessage="Codigo Postal Invalido" OnServerValidate="cusvaliCP_ServerValidate" ValidationGroup="grupo2">*</asp:CustomValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCp" ErrorMessage="Codigo Postal Invalido" ValidationExpression="^\d+$" ValidationGroup="grupo2">*</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="center";class="auto-style6">
                            <asp:Label ID="lblLocalidades" runat="server" Width="150px" Text="Localidades"></asp:Label>
                            <asp:DropDownList ID="ddlLocalidades" runat="server" Height="16px" Width="190px" Font-Bold="True" Font-Italic="False">
                                <asp:ListItem>--Seleccione Localidad--</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvLocalidades" runat="server" ErrorMessage="Ingrese una Localidad" ControlToValidate="ddlLocalidades" InitialValue="--Seleccione Localidad--" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>

            </div>
        <div style="width:100%;text-align:center;">
            <br />
            <asp:Button ID="btnUsuario" runat="server" Text="Guardar Usuario" Width="142px" ValidationGroup="grupo2" OnClick="btnUsuario_Click" />
        </div>
        <div style="width:100%;text-align:center;">
            <asp:Label ID="lblBinevenida" runat="server"></asp:Label>

        </div>
        <div style="width:100%;text-align:center;">
            <br />
            <asp:Button ID="btnVolverInicio" runat="server" Text="Volver Al Inicio" Width="142px" OnClick="btnVolverInicio_Click" />

        </div>
        <div >
            <asp:ValidationSummary ID="ValidationSummary" runat="server" ShowMessageBox="True" ValidationGroup="grupo1" />
        </div>
        <div >
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="grupo2" />
        </div>
    </form>
</body>
</html>
