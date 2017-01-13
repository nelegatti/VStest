<%@ Page Language="C#" AutoEventWireup="true" CodeFile="modificacion.aspx.cs" Inherits="modificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modificación Usuario</title>
</head>
    <h1>Modificación Usuario</h1>
<body>
    <form id="form1" runat="server">
    <div>
     Ingrese el nombre del usuario a modificar<asp:TextBox ID="TextBoxNameSearch" runat="server" Text="" Width="100" />
         <br />
     <asp:Button ID="ButtonSearch" runat="server" Text="Buscar" OnClick="ButtonSearch_Click" />
        <br />
     Nombre: <asp:TextBox ID="TextBoxNameUpdate" runat="server" Width="100" />
    <br />
     Password:<asp:TextBox ID="TextBoxPassUpdate" runat="server" Width="100" />
     <br />
     Email: <asp:TextBox ID="TextBoxEmailUpdate" runat="server" Width="100" /> 
    <br />
    <asp:Button ID="ButtonUpdate" runat="server" Text="Guardar" OnClick="ButtonUpdate_Click" />
    <br />
    <asp:Label ID="LabelUpdate" runat="server" Text=" " />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" Text="Retornar" NavigateUrl="~/Default.aspx" />
    <br />
    </div>
    </form>
</body>
</html>
