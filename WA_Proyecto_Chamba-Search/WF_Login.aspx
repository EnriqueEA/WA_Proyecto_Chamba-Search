<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_Login.aspx.cs" Inherits="WA_Proyecto_Chamba_Search.WF_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="//cdn.jsdelivr.net/bootstrap/3.2.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="//cdn.jsdelivr.net/jquery.bootstrapvalidator/0.5.0/css/bootstrapValidator.min.css" />
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <main role="main" class="container my-auto">
        <div class="row">
            <div id="login" class="col-lg-4 offset-lg-4 col-md-6 offset-md-3 col-12">
                <h2 class="text-center">Bienvenido de nuevo</h2>
                <img class="img-responsive mx-auto d-block rounded" src="https://picsum.photos/id/870/300/200" />
                <form id="form1" runat="server">
                    <!--<div>
                <div class="form-group">
                    <asp:Label ID="Label1" CssClass="control-label" runat="server" Text="Nombre del servicio:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNombreServ" CssClass="form-control" name="txtNombreServ" runat="server"></asp:TextBox>
                    <br />
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" CssClass="control-label" runat="server" Text="Tipo de Servicio:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTipoServicio" CssClass="form-control" runat="server"></asp:TextBox>
                    <br />
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" CssClass="control-label" runat="server" Text="Descripcion del Servicio"></asp:Label>
                    <br />
                    <textarea id="txtDescripcion" class="form-control" cols="20" name="S1" rows="2" runat="server"></textarea><br />
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" CssClass="control-label" runat="server" Text="Precio del Servicio:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <br />
                <br />
                <div class="form-group">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Servicio" />
                </div>
            </div>-->
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
    </main>
    <!-- jQuery and Bootstrap JS -->
    <script type="text/javascript" src="//cdn.jsdelivr.net/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript" src="//cdn.jsdelivr.net/bootstrap/3.2.0/js/bootstrap.min.js"></script>
    <!-- BootstrapValidator JS -->
    <script type="text/javascript" src="//cdn.jsdelivr.net/jquery.bootstrapvalidator/0.5.0/js/bootstrapValidator.min.js"></script>
    <script src="js/code.js"></script>
</body>
</html>
