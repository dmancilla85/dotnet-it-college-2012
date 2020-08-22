<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidarUsuarios.aspx.cs" Inherits="ValidarUsuarios" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validar Usuario</title>
    <style type="text/css">
        .style1 {
            width: 293px;
            height: 352px;
        }

        .style3 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="style1" title="Validar Usuario">
        <asp:Panel ID="Panel1" runat="server" BorderColor="#FF9900"
            BorderStyle="Dashed" Height="333px" HorizontalAlign="Center">
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Ingrese nombre"></asp:Label>
            <span lang="es-ar">&nbsp; </span>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="style3" Height="23px"
                OnTextChanged="txtNombre_TextChanged" Width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Ingrese clave"></asp:Label>
            <span lang="es-ar">&nbsp; </span>
            <asp:TextBox ID="txtPassword" runat="server" Style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click"
                Text="Enviar" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>