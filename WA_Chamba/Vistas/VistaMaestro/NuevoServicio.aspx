<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/VistaMaestro/Maestro.Master" AutoEventWireup="true" CodeBehind="NuevoServicio.aspx.cs" Inherits="WA_Proyecto_Chamba_Search.Vistas.VistaMaestro.NuevoServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
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
    </div>
</asp:Content>
