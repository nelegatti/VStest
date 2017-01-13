<%@ Page Language="C#" AutoEventWireup="true" CodeFile="carga.aspx.cs" Inherits="carga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carga de Comentarios</title>
</head>
    <h1> Bienvenido !</h1>
<body>
    <form id="form1" runat="server">
    <div>
     Ingrese su Nombre y Apellido: 
    <asp:TextBox ID="TextBox1" runat="server" />
    <br />
     Ingrese su País
    <asp:TextBox ID="TextBox2" runat="server" />
    <br />
    Comentarios:
    <br />
    <asp:TextBox ID="TextBox3" runat="server" Width ="400" Height="150" />

    </div>
    <asp:Button ID="Button1" runat="server" text="GUARDAR" OnClick="Button1_Click"/>
    <asp:Label ID="Label1" runat="server" Text="LABEL" />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Retornar</asp:HyperLink>
    </form>
</body>
</html>
