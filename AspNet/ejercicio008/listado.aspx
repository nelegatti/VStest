<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listado.aspx.cs" Inherits="listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listar Comentarios</title>
</head>
    <h1>Listado de Comentarios</h1>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID ="Label1" runat="server" Text="Waiting for Comment" />
    <br />
    <asp:HyperLink ID="HyperLink1" runat ="server" Text="Retornar" NavigateUrl="~/Default.aspx" />
    </div>
    </form>
</body>
</html>
