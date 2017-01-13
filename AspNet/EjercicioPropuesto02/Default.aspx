<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>MultipleChoise</title>
</head>
    <h1>EXAMEN MULTIPLE CHOISE</h1>
<body>
    <h3><strong>Bienvenido</strong> al examen</h3>
    <p>Seleccione la respuesta que usted cree correcta, solamente<br />
        existe una opción correcta por pregunta<br />
    </p>
    <form id="form1" runat="server">
    <div>
    1) ¿Capital de Chaco?<br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Resistencia" GroupName="G1" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Chaco" GroupName="G1"/>
        <asp:RadioButton ID="RadioButton3" runat="server" Text="Madrid" GroupName="G1"/>
    <br />
    2) ¿Raiz cuadrada de 144?<br />
        <asp:RadioButton ID="RadioButton4" runat="server" Text ="13" GroupName="G2" />
        <asp:RadioButton ID="RadioButton5" runat="server" Text="12" GroupName="G2" />
        <asp:RadioButton ID="RadioButton6" runat ="server" Text="14" GroupName="G2" />

    </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
    
    <h2>Errores</h2>
    <asp:Label ID="Label1" runat="server" Text=" "/>
    </form>
</body>
</html>
