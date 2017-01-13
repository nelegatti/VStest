<%@ Page Language="C#" AutoEventWireup="true" CodeFile="baja.aspx.cs" Inherits="baja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Eliminación</title>
    <h1>Eliminación de Usuario</h1>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Ingrese el nombre del usuario a eliminar:<asp:TextBox ID="TextBoxBaja" runat="server" Width="150" />
        <br />
        <asp:Label ID="LabelResultSearch" runat="server" Text =" " />
        <br />
        <asp:Button ID="ELIMINAR" runat="server" Text="ELIMINAR" OnClick="ELIMINAR_Click" />
        <br />
        <asp:Label ID="LabelResultOperation" runat="server" Text=" " />
        <br />
        <asp:HyperLink ID="LabelReturn" runat="server" NavigateUrl="~/Default.aspx" Text="Retornar" />
        <br />
    </div>
    </form>
</body>
</html>
