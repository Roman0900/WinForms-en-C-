<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_1.aspx.cs" Inherits="Trabajo_Practico_N4.Ejercicio_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 149px;
        }
        .auto-style6 {
            width: 135px;
            text-align: left;
        }
        .auto-style7 {
            width: 212px;
        }
        .auto-style8 {
            width: 206px;
        }
        .auto-style9 {
            width: 135px;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    

    <div class =" container well" >
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6"><strong>DESTINO INICIO</strong></td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">PROVINCIA:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlProvincia1" runat="server" OnSelectedIndexChanged="ddlProvincia1_SelectedIndexChanged" AutoPostBack="True" Height="35px" Width="250px" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">LOCALIDAD:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlLocalidad1" runat="server" OnSelectedIndexChanged="ddlLocalidad1_SelectedIndexChanged" AutoPostBack="True" Height="35px" Width="250px" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6"><strong>DESTINO FINAL:</strong></td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">PROVINCIA:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlProvincia2" runat="server" OnSelectedIndexChanged="ddlProvincia2_SelectedIndexChanged" AutoPostBack="True" Height="35px" Width="250px" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">LOCALIDAD:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlLocalidad2" runat="server" AutoPostBack="True" Height="35px" Width="250px" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
            </table>
             <div style="width:100%;text-align:center;">
       <br /><br />
       <asp:Button ID="Backbtn1" runat="server" Text="Volver al Menu" class="btn btn-primary dropdown-toggle" OnClick="Backbtn1_Click"  />
   </div>
        </div>
    </form>
        </div>
  

</body>
</html>