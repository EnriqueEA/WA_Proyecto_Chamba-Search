<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WA_Proyecto_Chamba_Search.Model._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" /><br />
            <asp:Button ID="btnSubir" runat="server" Text="Subir Archivo" OnClick="btnSubir_Click" /><br />
            <asp:Label ID="lblSalida" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
