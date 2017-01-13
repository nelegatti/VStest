<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 227px">
    <form id="form1" runat="server">
    <div style="height: 227px">
    Ingrese el Primer Valor
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Ingrese el Segundo Valor
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="1">SUMA</asp:ListItem>
            <asp:ListItem Value="2">RESTA</asp:ListItem>
            <asp:ListItem Value="3">MULTIPLICA</asp:ListItem>
            <asp:ListItem Value="4">DIVIDE</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="RESULTADO" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </div>
    </form>
</body>
</html>
