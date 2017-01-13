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
    
        Bienvenidos!
        <br />
        ---------------<br />
        Ingrese el Primer Valor<asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        <br />
        Ingrese el Segundo Valor<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="SUMAR" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="RESTAR" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="RESULTADO" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Esperando Operacion"></asp:Label>
    
    </div>
    </form>
</body>
</html>
