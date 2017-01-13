<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cookie</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Valor de la Cookie "edad":<asp:TextBox ID="TextBoxCookie" runat="server" />
    <br />
    <br />
    <asp:Button ID="ButtonCrear" runat="server" Text="Crear Cookie" OnClick="ButtonCrear_Click1" />
    <asp:Label ID="LabelResult" runat="server" Text=" " />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" 
        Text="Ir a la página Default.aspx" />
    <br />
    </div>
    </form>
</body>
</html>
