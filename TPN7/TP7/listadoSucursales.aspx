<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listadoSucursales.aspx.cs" Inherits="TP7_PROG3_2021_1C.listadoSucursales" %>

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
            width: 296px;
            text-align: right;
            margin-left: 80px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-align: right;
            width: 495px;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            width: 214px;
        }
        .auto-style8 {
            text-align: center;
            width: 241px;
        }
        .auto-style9 {
            width: 605px;
        }
        .auto-style10 {
            width: 99%;
            height: 622px;
        }
        .auto-style11 {
            height: 63px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Nro Grupo: 10</td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlkSeleccionSucursales" runat="server" NavigateUrl="~/listadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlkListadoSucursalesSeleccionadas" runat="server" NavigateUrl="~/mostrarSucursalesSeleccionadas.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Listado de sucursales</td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Busqueda nombre de sucursal:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txbBuscarSuc" runat="server" Width="355px"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnBuscar" runat="server" CssClass="auto-style6" Text="Buscar" OnClick="Buscar_click" />
                    </td>
                </tr>
            </table>
            
            <br />
            <div  style = "text-align: center">
                <asp:Label ID="lblaviso" runat="server"></asp:Label>
            </div>

            <br />
            <table class="auto-style10">
                <tr>
                    <td class="auto-style2">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DataList ID="dlProvincias" runat="server" DataKeyField="Id_Provincia" Width="285px">
                            <ItemTemplate>
                                &nbsp;<asp:Button ID="btnProvincia" runat="server" Height="50px" Text='<%# Eval("DescripcionProvincia") %>' Width="200px" CommandArgument='<%# Eval("Id_Provincia") %>' CommandName="comandoProvincia" OnCommand="btnProvincia_Command" />
                                <br />
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td class="auto-style9">
                        <asp:ListView ID="lvSucursales" runat="server" DataKeyNames="Id_Sucursal" GroupItemCount="3" OnPagePropertiesChanging="lvSucursales_PagePropertiesChanging">
                           <%-- <AlternatingItemTemplate>
                                <td runat="server" style="background-color: #FFFFFF;color: #284775;">Id_Sucursal:
                                    <asp:Label ID="Id_SucursalLabel" runat="server" Text='<%# Eval("Id_Sucursal") %>' />
                                    <br />NombreSucursal:
                                    <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                    <br />DescripcionSucursal:
                                    <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                    <br />URL_Imagen_Sucursal:
                                    <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                                    <br /></td>
                            </AlternatingItemTemplate>--%>
                            <EditItemTemplate>
                                <td runat="server" style="background-color: #999999;">Id_Sucursal:
                                    <asp:Label ID="Id_SucursalLabel1" runat="server" Text='<%# Eval("Id_Sucursal") %>' />
                                    <br />NombreSucursal:
                                    <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                    <br />DescripcionSucursal:
                                    <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                    <br />URL_Imagen_Sucursal:
                                    <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                    <br />
                                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                    <br />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                    <br /></td>
                            </EditItemTemplate>
                            <EmptyDataTemplate>
                                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                                    <tr>
                                        <td>No se han devuelto datos.</td>
                                    </tr>
                                </table>
                            </EmptyDataTemplate>
                            <EmptyItemTemplate>
<td runat="server" />
                            </EmptyItemTemplate>
                            <GroupTemplate>
                                <tr id="itemPlaceholderContainer" runat="server">
                                    <td id="itemPlaceholder" runat="server"></td>
                                </tr>
                            </GroupTemplate>
                            <InsertItemTemplate>
                                <td runat="server" style="">NombreSucursal:
                                    <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                    <br />DescripcionSucursal:
                                    <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                    <br />URL_Imagen_Sucursal:
                                    <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                    <br />
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                    <br />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                    <br /></td>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <td runat="server" style="background-color: #E0FFFF;color: #333333;" class="auto-style8"><strong>
                                    <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>'></asp:Label>
                                    </strong>
                                    <br />
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="200px" ImageUrl='<%# Eval("URL_Imagen_Sucursal") %>' />
                                    <br />
                                    <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                    <br />
                                    <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CommandArgument='<%# Eval("Id_Sucursal")+"-"+Eval("NombreSucursal")+"-"+Eval("DescripcionSucursal") %>' CommandName="comandoSeleccionarLvSucurales" OnCommand="btnSeleccionar_Command" />
                                    <br /></td>
                            </ItemTemplate>
                            <LayoutTemplate>
                                <table runat="server">
                                    <tr runat="server">
                                        <td runat="server">
                                            <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                                <tr id="groupPlaceholder" runat="server">
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr runat="server">
                                        <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF" class="auto-style11">
                                            <asp:DataPager ID="DataPager1" runat="server" PageSize="6" PagedControlID="lvSucursales">
                                                <Fields>
                                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                    <asp:NumericPagerField />
                                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                </Fields>
                                            </asp:DataPager>
                                        </td>
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <SelectedItemTemplate>
                                <td runat="server" style="background-color: #E2DED6;font-weight: bold;color: #333333;">Id_Sucursal:
                                    <asp:Label ID="Id_SucursalLabel" runat="server" Text='<%# Eval("Id_Sucursal") %>' />
                                    <br />NombreSucursal:
                                    <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                    <br />DescripcionSucursal:
                                    <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                    <br />URL_Imagen_Sucursal:
                                    <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                                    <br /></td>
                            </SelectedItemTemplate>
                        </asp:ListView>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Label ID="lblIntegrantes" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
