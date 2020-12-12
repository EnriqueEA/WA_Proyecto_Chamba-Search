<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/VistaAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WA_Chamba.Vistas.VistaAdmin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="info">
        <div class="container">
            <asp:Image ID="Image1" runat="server" CssClass="crop" />
        </div>
        <div class="desc">
        <asp:Label ID="lblInfo" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
