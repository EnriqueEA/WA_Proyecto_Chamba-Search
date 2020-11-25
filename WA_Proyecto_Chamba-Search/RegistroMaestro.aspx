<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroMaestro.aspx.cs" Inherits="WA_Proyecto_Chamba_Search.RegistroMaestro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group row">
        <div class="col">
            <asp:Label ID="Label1" runat="server" Text="Nombres:"></asp:Label>
            <asp:TextBox ID="txtNombres" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col">
            <asp:Label ID="Label2" CssClass="col-sm-2 col-form-label" runat="server" Text="Apellido Paterno:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPaterno" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="col">
            <asp:Label ID="Label3" CssClass="col-sm-2 col-form-label" runat="server" Text="Apellido Materno:"></asp:Label>
            <br />
            <asp:TextBox ID="txtMaterno" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="col">
            <asp:Label ID="Label4" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
            <br />
            <asp:TextBox ID="txtFechaNac" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
            <br />
        </div>
    </div>

    <div class="row">
        <div class="col-2">
            <asp:Label ID="Label6" runat="server" Text="Sexo:"></asp:Label>
            <br />
            <asp:RadioButtonList ID="rdSexo" runat="server">
                <asp:ListItem Value="H">Hombre</asp:ListItem>
                <asp:ListItem Value="M">Mujer</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="col-3">
            <asp:Label ID="Label7" runat="server" Text="DNI:"></asp:Label>
            <br />
            <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="col">
            <asp:Label ID="Label10" runat="server" Text="Distrito:"></asp:Label>
            <br />
            <asp:DropDownList ID="cboDistrito" CssClass="custom-select mr-sm-2" runat="server">
            </asp:DropDownList>
            <br />
        </div>
        <div class="col">
            <asp:Label ID="Label5" runat="server" Text="Celular:"></asp:Label>
            <br />
            <asp:TextBox ID="txtCelular" cssClass="form-control" runat="server"></asp:TextBox>
            <br />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <asp:Label ID="Label8" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" cssClass="form-control" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="col">
            <asp:Label ID="Label11" runat="server" Text="Usuario:"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsusario" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <asp:Label ID="Label12" runat="server" Text="Contraseña:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        </div>
        <div class="col">
            <asp:Label ID="Label13" runat="server" Text="Vuelva a escribir la contraseña:"></asp:Label>
            <br />
            <asp:TextBox ID="txtRepetirPswd" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        </div>
        <div class="col">
            <div class="custom-file">
                <asp:Label ID="Label9" CssClass="custom-file-label" runat="server" Text="Imagen de Perfil:"></asp:Label>
                <br />
                <asp:FileUpload CssClass="custom-file-input" ID="fileupload" runat="server" />
                <br />
            </div>
        </div>
    </div>
    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Registrarse" />
    <br />
        <!---
    <div class="jumbotron">
        <div class="container text-center">
            <h1>My Portfolio</h1>
            <p>Some text that represents "Me"...</p>
        </div>
    </div>

    <div class="container-fluid bg-3 text-center">
        <h3>Some of my Work</h3>
        <br>
        <div class="row">
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
        </div>
    </div>
    <br>

    <div class="container-fluid bg-3 text-center">
        <div class="row">
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
            <div class="col-sm-3">
                <p>Some text..</p>
                <img src="https://placehold.it/150x80?text=IMAGE" class="img-responsive" style="width: 100%" alt="Image">
            </div>
        </div>
    </div>-->
</asp:Content>
