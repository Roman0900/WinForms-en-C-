<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_4.2.aspx.cs" Inherits="Trabajo_Practico_N2.Ejercicio_4__2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <span class="auto-style1"><strong>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp; Bienvenido a mi página sr/a</strong></span> <strong>
            <asp:Label ID="lblUsuario" runat="server" CssClass="auto-style1"></asp:Label>
            </strong>
            <br />
        </div>
         <div style="width:100%;text-align:center;">
            <br /><br />
            <asp:Button ID="returnbtn" runat="server" Text="Volver al Menu Principal" OnClick="returnbtn_Click" />
        </div>
    </form>
</body>
</html>
