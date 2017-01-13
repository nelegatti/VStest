<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
</head>
    <h1> Bienvenido ! </h1>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/alta.aspx" Text="Alta de Usuario"/>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/modificacion.aspx" Text="Modificacion de Usuario" />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/baja.aspx" Text="Eliminar Usuario" />
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/consulta.aspx" Text="Consultar Usuarios" />
        <br />
    </div>
    </form>
</body>
</html>
