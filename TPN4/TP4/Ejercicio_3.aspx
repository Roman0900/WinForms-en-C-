<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_3.aspx.cs" Inherits="Trabajo_Practico_N4.Ejercicio_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 3</title>
    <style type="text/css">

    .auto-style3 {
        width: 100%;
    }
    
        .auto-style2 {
            width: 544px;
        }
    .auto-style5 {
        width: 544px;
        height: 23px;
    }
    .auto-style6 {
        height: 23px;
    }
        .auto-style7 {
            width: 666px;
        }
        .auto-style8 {
            width: 666px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style7" style="font-size: x-large;text-align:right; font-weight: bold">Seleccionar tema : </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlTema" runat="server" Width="301px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td style="font-size: large;text-align:center;" colspan="3">
                    
                   
                    
                    <asp:LinkButton ID="link1" runat="server" OnClick="link1_Click">Ver libros</asp:LinkButton>
                </td>
            </tr>
        </table>
        <div style="width:100%;text-align:center;">
            <br />
            <br />
            <asp:Button ID="Backmenu3" runat="server" Text="Volver Al menu" OnClick="Backmenu3_Click" />

        </div>
    </form>
</body>
</html>
