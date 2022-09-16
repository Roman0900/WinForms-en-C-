<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_5.aspx.cs" Inherits="Trabajo_Practico_N2.Ejercicio_5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
&nbsp;<head runat="server"><meta http-equiv="Content-Type" content="text/html; charset=utf-8"/><title></title><style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 545px;
        }
        .auto-style3 {
            width: 545px;
            text-align: right;
        }
        .auto-style4 {
            margin-left: 43px;
        }
        .auto-style5 {
            width: 545px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style></head><body><form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <h2><strong>Elija su configuración</strong></h2>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Seleccione cantidad de memoria</strong></td>
                    <td><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seleccione accesorios</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlCantidadMemoria" runat="server" Width="115px">
                            <asp:ListItem Value="200">2 GB</asp:ListItem>
                            <asp:ListItem Value="375">4 GB</asp:ListItem>
                            <asp:ListItem Value="500">6 GB</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="cblAccesorios" runat="server" CssClass="auto-style4" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                            <asp:ListItem Value="2000,50">Monitor LCD</asp:ListItem>
                            <asp:ListItem Value="550,50">HD 500GB</asp:ListItem>
                            <asp:ListItem Value="1200">Grabador DVD</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCalcularPrecio" runat="server" Text="Calcular Precio" Width="127px" OnClick="btnCalcularPrecio_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblPrecioFinal" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
         <div style="width:100%;text-align:center;">
            <br /><br />
            <asp:Button ID="returnbtn" runat="server" Text="Volver al Menu Principal" OnClick="returnbtn_Click" />
        </div>
    </form>
</body>
</html>