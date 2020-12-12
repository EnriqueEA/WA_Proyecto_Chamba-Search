<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginMaestro.aspx.cs" Inherits="WA_Proyecto_Chamba_Search.Vistas.VistaMaestro.LoginMaestro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="//cdn.jsdelivr.net/bootstrap/3.2.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="//cdn.jsdelivr.net/jquery.bootstrapvalidator/0.5.0/css/bootstrapValidator.min.css" />
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <main role="main" class="xfull-container">
        <div class="loginIntro">
            <div class="left" style="background-image: url(img/trabajador.jpg);">
            </div>
            <div class="right">
                <div class="rightMid">
                    <h2 class="text-center">Bienvenido de nuevo</h2>
                    <form id="form1" runat="server" class="container corto">

                        <div class="form-group">
                            <asp:Label ID="lblU" runat="server" Text="Usuario" for="txtUsuario"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label ID="lblC" runat="server" Text="Contraseña"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtPassw" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            <br />
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnIngresar" CssClass="btn btn-primary mb-2" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                        </div>
                        <a href="#">Contraseña olvidada</a>
                    </form>
                </div>
            </div>
        </div>
    </main>
    <!-- jQuery and Bootstrap JS -->
    <script type="text/javascript" src="//cdn.jsdelivr.net/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript" src="//cdn.jsdelivr.net/bootstrap/3.2.0/js/bootstrap.min.js"></script>
    <!-- BootstrapValidator JS -->
    <script type="text/javascript" src="//cdn.jsdelivr.net/jquery.bootstrapvalidator/0.5.0/js/bootstrapValidator.min.js"></script>
    <script src="js/code.js"></script>
</body>
</html>
