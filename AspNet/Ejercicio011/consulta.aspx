<%@ Page Language="C#" AutoEventWireup="true" CodeFile="consulta.aspx.cs" Inherits="consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta de Usuarios</title>
</head>
    <h1> CONSULTA DE USUARIOS</h1>
<body>
    <form id="form1" runat="server">
    <div> 
        INGRESE EL NOMBRE DEL USUARIO<asp:TextBox ID="TextBoxNombre" runat="server" /> <br />
        <asp:Button ID="ButtonSearch" runat="server" Text="Buscar" OnClick="ButtonSearch_Click"/><br />
        <asp:Label ID="LabelResult" runat="server" Text=" " /><br />
        <asp:HyperLink ID="HyperLinkReturn" runat="server" NavigateUrl="~/Default.aspx" Text="Retornar" />
    </div>
    </form>
</body>
</html>
