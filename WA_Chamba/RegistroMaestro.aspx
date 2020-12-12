<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroMaestro.aspx.cs" Inherits="WA_Proyecto_Chamba_Search.RegistroMaestro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="Label1" runat="server" Text="Nombres:"></asp:Label>
        <asp:TextBox ID="txtNombres" CssClass="form-control" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Apellido Paterno:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPaterno" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Apellido Materno:"></asp:Label>
        <br />
        <asp:TextBox ID="txtMaterno" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
        <br />
        <asp:TextBox ID="txtFechaNac" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <asp:Image ID="Image1" runat="server" />

        <asp:Label ID="Label6" runat="server" Text="Sexo:"></asp:Label>
        <br />
        <asp:DropDownList ID="cboSexo" runat="server" CssClass="form-control">
            <asp:ListItem>Seleccione</asp:ListItem>
            <asp:ListItem Value="H">Hombre</asp:ListItem>
            <asp:ListItem Value="M">Mujer</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label7" runat="server" Text="DNI:"></asp:Label>
        <br />
        <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Distrito:"></asp:Label>
        <br />
        <asp:DropDownList ID="cboDistrito" CssClass="custom-select mr-sm-2" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Celular:"></asp:Label>
        <br />
        <asp:TextBox ID="txtCelular" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Usuario:"></asp:Label>
        <br />
        <asp:TextBox ID="txtUsusario" CssClass="form-control" runat="server"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" Text="Contraseña:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="Vuelva a escribir la contraseña:"></asp:Label>
        <br />
        <asp:TextBox ID="txtRepetirPswd" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Imagen de Perfil:">Seleccione una Imagen</asp:Label>
        <br />
        <asp:FileUpload ID="fileupload" runat="server" />
        <br />
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Registrarse" />
    </div>
</asp:Content>
