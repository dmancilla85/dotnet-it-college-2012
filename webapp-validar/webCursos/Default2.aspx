<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prueba 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="cboPaises" runat="server" AutoPostBack="True"
                OnSelectedIndexChanged="cboPaises_SelectedIndexChanged" Style="height: 22px">
            </asp:DropDownList>
        </div>
        <asp:Label ID="lblPais" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click"
                Text="Mostrar" />
        </p>
    </form>
</body>
</html>