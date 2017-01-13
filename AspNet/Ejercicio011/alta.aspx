<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alta.aspx.cs" Inherits="alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Alta de Usuario</title>
</head>
    <h1>ALTA DE USUARIOS</h1>
    <p> A continuación va  poder crear usuarios para el sistema.<br />
        Por favor ingrese los <em>datos</em> solicitados.
    </p>
<body>
    <form id="form1" runat="server">
    <div>
    Nombre:
    <asp:TextBox ID="TextBoxName" runat="server" Width="250"/>
    <br />
    <br />
    Clave:
    <asp:TextBox ID="TextBoxPassword" runat="server" Width="250" TextMode="Password"/>
    <br />
    <br />
    Email:
    <asp:TextBox ID="TextBoxEmail" runat="server" Width="250"/>
    </div>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Guardar" BorderColor="Green" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="LabelResult" runat="server" Text=" " />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Text="Retornar"/>
    </form>
</body>
</html>
