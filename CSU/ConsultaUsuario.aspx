<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="Proyecto_3_REST_David_Cerdas.CSU.ConsultaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="imgUsuario" runat="server" />
        <div>
            <asp:Label ID="lbTitulo" runat="server" Text="Título: "></asp:Label>
            <asp:TextBox ID="tbTitulo" runat="server" Width="215px"></asp:TextBox>
        <div>
            <asp:Label ID="lbNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="tbNombre" runat="server" Width="215px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbApellidos" runat="server" Text="Apellidos: "></asp:Label>
            <asp:TextBox ID="tbApellidos" runat="server" Width="215px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbUsuario" runat="server" Text="Usuario:"></asp:Label>
            <asp:TextBox ID="tbUsuario" runat="server" Width="215px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbContrasena" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="tbContrasena" runat="server" Width="215px"></asp:TextBox>
        </div>
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" />
            <br />
        </div>
    </form>
</body>
</html>
