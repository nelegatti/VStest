<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>EJERCICIO1</title>
</head>
    <h1>BIENVENIDO </h1>
<body>
    <form id="form1" runat="server">
    <div>
    Ingrese el Nombre:<asp:TextBox ID="TextBox1" runat="server" Text ="" />
    <br />
    Ingrese el Apellido:<asp:TextBox ID="TextBox2" runat="server" Text="" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text=" " />

    </div>
    </form>
</body>
</html>
