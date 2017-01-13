<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Bienvenido !</h1>
        <br />
        ----------------<br />
        <strong>Ingrese el Primer Valor:</strong><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <strong>Ingrese el Segundo Valor:</strong><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="123px">
            <asp:ListItem Value="1">SUMA</asp:ListItem>
            <asp:ListItem Value="2">RESTA</asp:ListItem>
            <asp:ListItem Value="3">MULTIPLICACION</asp:ListItem>
            <asp:ListItem Value="4">DIVISION</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="RESULTADO" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Esperando Operación"></asp:Label>
    
    </div>
    </form>
</body>
</html>
