<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Default3</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Ingrese mail:<asp:TextBox ID="TextBoxMail" runat="server"/><br />
        <br />
        <asp:Button ID="ButtonAddMail" runat="server" Text="Guardar" OnClick="ButtonAddMail_Click"/>
        
    </div>
    </form>
</body>
</html>
