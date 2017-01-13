<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cookie</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Valor de la Cookie: <asp:Label ID="LabelCkResult"  runat="server" Text=" " />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx" Text="Ir a Crear Cookie" />

    </div>
    </form>
</body>
</html>
