<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 243px">
    
        Bienvenido !
        <br />
        -------------<br />
        Ingrese el primer valor:<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        Ingrese el segundo valor:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="G1" Text="SUMAR" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="G1" Text="RESTAR" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="RESULTADO" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text ="Esperando Operación "></asp:Label>
    
    </div>
    </form>
</body>
</html>
